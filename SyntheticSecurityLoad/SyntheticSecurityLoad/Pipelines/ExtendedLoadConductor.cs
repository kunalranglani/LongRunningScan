using SyntheticSecurityLoad.Models;
using SyntheticSecurityLoad.Stores;
using SyntheticSecurityLoad.Transform;

namespace SyntheticSecurityLoad.Pipelines;

public sealed class ExtendedLoadConductor
{
    private readonly ScanLoadOrchestrator _orchestrator = new();
    private readonly CascadeLedgerAnalyzer _cascade = new();
    private readonly EnvelopeMutationDeck _deck = new();

    public IReadOnlyList<string> RunExpanded(PayloadEnvelope envelope)
    {
        var all = new List<string>();
        foreach (var r in _orchestrator.RunAll(envelope))
        {
            all.Add(r.Evidence);
        }

        for (var i = 1; i <= 40; i++)
        {
            all.Add(_deck.MutatePattern1(envelope));
            all.Add(_cascade.DeriveCascade1(envelope));
        }

        return all;
    }
}
