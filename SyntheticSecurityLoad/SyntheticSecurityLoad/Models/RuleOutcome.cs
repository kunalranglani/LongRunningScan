namespace SyntheticSecurityLoad.Models;

public sealed record RuleOutcome(
    string RuleName,
    bool IsFlagged,
    string Evidence,
    int Score,
    string Classification
);
