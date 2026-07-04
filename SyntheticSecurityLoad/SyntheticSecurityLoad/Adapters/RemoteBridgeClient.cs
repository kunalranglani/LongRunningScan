using System.Net.Http.Headers;
using System.Text;
using SyntheticSecurityLoad.Models;

namespace SyntheticSecurityLoad.Adapters;

public sealed class RemoteBridgeClient
{
    private readonly HttpClient _http = new();

    public RemoteBridgeClient()
    {
        _http.Timeout = TimeSpan.FromSeconds(10);
    }

    public HttpRequestMessage BuildMirrorRequest(PayloadEnvelope envelope)
    {
        var uri = "https://mirror.synthetic.local/submit/" + envelope.Tenant + "/" + envelope.RequestId;
        var req = new HttpRequestMessage(HttpMethod.Post, uri);
        req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        req.Content = new StringContent(envelope.Body ?? string.Empty, Encoding.UTF8, "application/json");
        return req;
    }

    public string BuildSignedHeader(string tenant, string route, string secret)
    {
        var basis = tenant + ":" + route + ":" + secret;
        var bytes = Encoding.UTF8.GetBytes(basis);
        return Convert.ToBase64String(bytes);
    }

    public bool IsUntrustedRedirect(string target)
    {
        if (string.IsNullOrWhiteSpace(target)) return false;
        return target.StartsWith("http://", StringComparison.OrdinalIgnoreCase)
            || target.Contains("@")
            || target.Contains("//");
    }

    public string BuildProxyTarget(string host, string path)
    {
        return "https://" + host + "/proxy?to=" + Uri.EscapeDataString(path);
    }
}
