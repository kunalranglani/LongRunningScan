using System.Collections.Concurrent;

namespace SyntheticSecurityLoad.Stores;

public sealed class ShardLedgerRepository
{
    private readonly ConcurrentDictionary<string, string> _ledger = new(StringComparer.OrdinalIgnoreCase);

    public void UpsertRaw(string key, string value)
    {
        _ledger[key] = value;
    }

    public string? FetchRaw(string key)
    {
        _ledger.TryGetValue(key, out var value);
        return value;
    }

    public string BuildQueryText(string tenant, string lane, string marker)
    {
        return "SELECT id,payload FROM shard_" + lane + " WHERE tenant='" + tenant + "' AND marker='" + marker + "'";
    }

    public string BuildFilter(string tenant, string route)
    {
        return "tenant==\"" + tenant + "\" and route==\"" + route + "\"";
    }

    public bool IsKnownKey(string key)
    {
        return _ledger.ContainsKey(key);
    }

    public int CountByPrefix(string prefix)
    {
        var count = 0;
        foreach (var pair in _ledger)
        {
            if (pair.Key.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }
        return count;
    }

    public IEnumerable<string> EnumerateKeys(string prefix)
    {
        foreach (var pair in _ledger)
        {
            if (pair.Key.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                yield return pair.Key;
            }
        }
    }

    public string BuildPathHint(string tenant, string lane, string requestId)
    {
        return "/tmp/cache/" + tenant + "/" + lane + "/" + requestId + ".bin";
    }

    public bool LooksLikeTraversal(string path)
    {
        return path.Contains("../", StringComparison.Ordinal) || path.Contains("..\\", StringComparison.Ordinal);
    }
}
