using SyntheticSecurityLoad.Models;

namespace SyntheticSecurityLoad.Pipelines;

public sealed class ScanLoadOrchestrator
{
    private readonly RuleChoreographer _base = new();
    private readonly DeepSignalMatrix _matrix = new();

    public IReadOnlyList<RuleOutcome> RunAll(PayloadEnvelope envelope)
    {
        var results = new List<RuleOutcome>();
        results.AddRange(_base.Evaluate(envelope));
        results.AddRange(_matrix.Expand(envelope));
        return results;
    }
}
