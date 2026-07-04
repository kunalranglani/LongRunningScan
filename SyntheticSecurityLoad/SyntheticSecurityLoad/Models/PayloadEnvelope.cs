namespace SyntheticSecurityLoad.Models;

public sealed record PayloadEnvelope(
    string RequestId,
    string Tenant,
    string Source,
    string Body,
    string Route,
    string Tag,
    int Revision,
    DateTimeOffset SeenAt
);
