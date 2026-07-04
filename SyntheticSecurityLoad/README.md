# SyntheticSecurityLoad

This synthetic C# project is designed to mimic long-running security scans with high LLM fan-out.

## Why it triggers heavy scans
- A small number of files with many methods.
- Repeated security-relevant string and data-flow patterns.
- Per-method rule evaluation and evidence construction.
- Large method count in one orchestrator class (RuleChoreographer).

## Structure
- Intake/EnvelopeGateway.cs
- Stores/ShardLedgerRepository.cs
- Pipelines/RuleChoreographer.cs
- Adapters/RemoteBridgeClient.cs
- Transform/DeltaPatchComposer.cs

## Build
- dotnet build SyntheticSecurityLoad.sln

## Notes
All names are synthetic and newly generated for this sample.
