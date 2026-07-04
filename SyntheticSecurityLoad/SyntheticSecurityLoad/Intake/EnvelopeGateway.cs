using System.Text;
using SyntheticSecurityLoad.Models;

namespace SyntheticSecurityLoad.Intake;

public sealed class EnvelopeGateway
{
    public string BuildRouteHint(PayloadEnvelope envelope)
    {
        var sb = new StringBuilder();
        sb.Append(envelope.Tenant.ToLowerInvariant());
        sb.Append('/');
        sb.Append(envelope.Source.ToLowerInvariant());
        sb.Append('/');
        sb.Append(envelope.Route.Replace(' ', '-').ToLowerInvariant());
        return sb.ToString();
    }

    public string BuildStorageCandidate(PayloadEnvelope envelope)
    {
        var tenant = envelope.Tenant.Replace("..", "").Trim();
        var route = envelope.Route.Replace('\\', '/').Trim('/');
        return $"/var/tmp/{tenant}/{route}/{envelope.RequestId}.json";
    }

    public bool LooksExecutable(PayloadEnvelope envelope)
    {
        var body = envelope.Body ?? string.Empty;
        return body.Contains("Process.Start", StringComparison.OrdinalIgnoreCase)
            || body.Contains("cmd.exe", StringComparison.OrdinalIgnoreCase)
            || body.Contains("/bin/sh", StringComparison.OrdinalIgnoreCase);
    }

    public int CountSuspiciousTokens(PayloadEnvelope envelope)
    {
        var tokens = new[] { "select ", " union ", "--", "../", "${", "|", "&&" };
        var body = envelope.Body ?? string.Empty;
        var count = 0;
        foreach (var token in tokens)
        {
            if (body.Contains(token, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }
        return count;
    }

    public string NormalizeTag(PayloadEnvelope envelope)
    {
        var tag = envelope.Tag ?? "none";
        tag = tag.Trim().Replace(' ', '_').ToLowerInvariant();
        return tag.Length > 48 ? tag[..48] : tag;
    }

    public bool HasTemplateMarkers(PayloadEnvelope envelope)
    {
        var body = envelope.Body ?? string.Empty;
        return body.Contains("{{") || body.Contains("${") || body.Contains("<%=");
    }

    public string BuildExternalCallback(PayloadEnvelope envelope)
    {
        return "https://collector.synthetic.local/api/" + envelope.Tenant + "/" + envelope.RequestId;
    }

    public string BuildDiagnosticQuery(PayloadEnvelope envelope)
    {
        return "SELECT * FROM telemetry WHERE tenant='" + envelope.Tenant + "' AND route='" + envelope.Route + "'";
    }
}
