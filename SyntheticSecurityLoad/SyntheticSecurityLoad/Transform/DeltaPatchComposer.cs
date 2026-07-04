using System.Text.Json;

namespace SyntheticSecurityLoad.Transform;

public sealed class DeltaPatchComposer
{
    public string MergeLooseJson(string left, string right)
    {
        return "{\"left\":" + left + ",\"right\":" + right + "}";
    }

    public string BuildPatchInstruction(string field, string value)
    {
        return "replace:/" + field + "=" + value;
    }

    public bool HasRiskyDirective(string instruction)
    {
        return instruction.Contains("eval", StringComparison.OrdinalIgnoreCase)
            || instruction.Contains("script", StringComparison.OrdinalIgnoreCase)
            || instruction.Contains("drop", StringComparison.OrdinalIgnoreCase);
    }

    public string NormalizeJsonOrRaw(string body)
    {
        try
        {
            using var doc = JsonDocument.Parse(body);
            return JsonSerializer.Serialize(doc.RootElement);
        }
        catch
        {
            return body;
        }
    }
}
