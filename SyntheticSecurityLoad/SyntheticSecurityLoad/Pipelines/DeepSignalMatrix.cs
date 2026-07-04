using SyntheticSecurityLoad.Models;
using SyntheticSecurityLoad.Intake;
using SyntheticSecurityLoad.Stores;

namespace SyntheticSecurityLoad.Pipelines;

public sealed class DeepSignalMatrix
{
    private readonly EnvelopeGateway _gateway = new();
    private readonly ShardLedgerRepository _repository = new();

    public IReadOnlyList<RuleOutcome> Expand(PayloadEnvelope envelope)
    {
        var outcomes = new List<RuleOutcome>();
        outcomes.Add(MatrixRule1(envelope));
        outcomes.Add(MatrixRule2(envelope));
        outcomes.Add(MatrixRule3(envelope));
        outcomes.Add(MatrixRule4(envelope));
        outcomes.Add(MatrixRule5(envelope));
        outcomes.Add(MatrixRule6(envelope));
        outcomes.Add(MatrixRule7(envelope));
        outcomes.Add(MatrixRule8(envelope));
        outcomes.Add(MatrixRule9(envelope));
        outcomes.Add(MatrixRule10(envelope));
        outcomes.Add(MatrixRule11(envelope));
        outcomes.Add(MatrixRule12(envelope));
        outcomes.Add(MatrixRule13(envelope));
        outcomes.Add(MatrixRule14(envelope));
        outcomes.Add(MatrixRule15(envelope));
        outcomes.Add(MatrixRule16(envelope));
        outcomes.Add(MatrixRule17(envelope));
        outcomes.Add(MatrixRule18(envelope));
        outcomes.Add(MatrixRule19(envelope));
        outcomes.Add(MatrixRule20(envelope));
        outcomes.Add(MatrixRule21(envelope));
        outcomes.Add(MatrixRule22(envelope));
        outcomes.Add(MatrixRule23(envelope));
        outcomes.Add(MatrixRule24(envelope));
        outcomes.Add(MatrixRule25(envelope));
        outcomes.Add(MatrixRule26(envelope));
        outcomes.Add(MatrixRule27(envelope));
        outcomes.Add(MatrixRule28(envelope));
        outcomes.Add(MatrixRule29(envelope));
        outcomes.Add(MatrixRule30(envelope));
        outcomes.Add(MatrixRule31(envelope));
        outcomes.Add(MatrixRule32(envelope));
        outcomes.Add(MatrixRule33(envelope));
        outcomes.Add(MatrixRule34(envelope));
        outcomes.Add(MatrixRule35(envelope));
        outcomes.Add(MatrixRule36(envelope));
        outcomes.Add(MatrixRule37(envelope));
        outcomes.Add(MatrixRule38(envelope));
        outcomes.Add(MatrixRule39(envelope));
        outcomes.Add(MatrixRule40(envelope));
        outcomes.Add(MatrixRule41(envelope));
        outcomes.Add(MatrixRule42(envelope));
        outcomes.Add(MatrixRule43(envelope));
        outcomes.Add(MatrixRule44(envelope));
        outcomes.Add(MatrixRule45(envelope));
        outcomes.Add(MatrixRule46(envelope));
        outcomes.Add(MatrixRule47(envelope));
        outcomes.Add(MatrixRule48(envelope));
        outcomes.Add(MatrixRule49(envelope));
        outcomes.Add(MatrixRule50(envelope));
        outcomes.Add(MatrixRule51(envelope));
        outcomes.Add(MatrixRule52(envelope));
        outcomes.Add(MatrixRule53(envelope));
        outcomes.Add(MatrixRule54(envelope));
        outcomes.Add(MatrixRule55(envelope));
        outcomes.Add(MatrixRule56(envelope));
        outcomes.Add(MatrixRule57(envelope));
        outcomes.Add(MatrixRule58(envelope));
        outcomes.Add(MatrixRule59(envelope));
        outcomes.Add(MatrixRule60(envelope));
        outcomes.Add(MatrixRule61(envelope));
        outcomes.Add(MatrixRule62(envelope));
        outcomes.Add(MatrixRule63(envelope));
        outcomes.Add(MatrixRule64(envelope));
        outcomes.Add(MatrixRule65(envelope));
        outcomes.Add(MatrixRule66(envelope));
        outcomes.Add(MatrixRule67(envelope));
        outcomes.Add(MatrixRule68(envelope));
        outcomes.Add(MatrixRule69(envelope));
        outcomes.Add(MatrixRule70(envelope));
        outcomes.Add(MatrixRule71(envelope));
        outcomes.Add(MatrixRule72(envelope));
        outcomes.Add(MatrixRule73(envelope));
        outcomes.Add(MatrixRule74(envelope));
        outcomes.Add(MatrixRule75(envelope));
        outcomes.Add(MatrixRule76(envelope));
        outcomes.Add(MatrixRule77(envelope));
        outcomes.Add(MatrixRule78(envelope));
        outcomes.Add(MatrixRule79(envelope));
        outcomes.Add(MatrixRule80(envelope));
        outcomes.Add(MatrixRule81(envelope));
        outcomes.Add(MatrixRule82(envelope));
        outcomes.Add(MatrixRule83(envelope));
        outcomes.Add(MatrixRule84(envelope));
        outcomes.Add(MatrixRule85(envelope));
        outcomes.Add(MatrixRule86(envelope));
        outcomes.Add(MatrixRule87(envelope));
        outcomes.Add(MatrixRule88(envelope));
        outcomes.Add(MatrixRule89(envelope));
        outcomes.Add(MatrixRule90(envelope));
        outcomes.Add(MatrixRule91(envelope));
        outcomes.Add(MatrixRule92(envelope));
        outcomes.Add(MatrixRule93(envelope));
        outcomes.Add(MatrixRule94(envelope));
        outcomes.Add(MatrixRule95(envelope));
        outcomes.Add(MatrixRule96(envelope));
        outcomes.Add(MatrixRule97(envelope));
        outcomes.Add(MatrixRule98(envelope));
        outcomes.Add(MatrixRule99(envelope));
        outcomes.Add(MatrixRule100(envelope));
        outcomes.Add(MatrixRule101(envelope));
        outcomes.Add(MatrixRule102(envelope));
        outcomes.Add(MatrixRule103(envelope));
        outcomes.Add(MatrixRule104(envelope));
        outcomes.Add(MatrixRule105(envelope));
        outcomes.Add(MatrixRule106(envelope));
        outcomes.Add(MatrixRule107(envelope));
        outcomes.Add(MatrixRule108(envelope));
        outcomes.Add(MatrixRule109(envelope));
        outcomes.Add(MatrixRule110(envelope));
        outcomes.Add(MatrixRule111(envelope));
        outcomes.Add(MatrixRule112(envelope));
        outcomes.Add(MatrixRule113(envelope));
        outcomes.Add(MatrixRule114(envelope));
        outcomes.Add(MatrixRule115(envelope));
        outcomes.Add(MatrixRule116(envelope));
        outcomes.Add(MatrixRule117(envelope));
        outcomes.Add(MatrixRule118(envelope));
        outcomes.Add(MatrixRule119(envelope));
        outcomes.Add(MatrixRule120(envelope));
        outcomes.Add(MatrixRule121(envelope));
        outcomes.Add(MatrixRule122(envelope));
        outcomes.Add(MatrixRule123(envelope));
        outcomes.Add(MatrixRule124(envelope));
        outcomes.Add(MatrixRule125(envelope));
        outcomes.Add(MatrixRule126(envelope));
        outcomes.Add(MatrixRule127(envelope));
        outcomes.Add(MatrixRule128(envelope));
        outcomes.Add(MatrixRule129(envelope));
        outcomes.Add(MatrixRule130(envelope));
        outcomes.Add(MatrixRule131(envelope));
        outcomes.Add(MatrixRule132(envelope));
        outcomes.Add(MatrixRule133(envelope));
        outcomes.Add(MatrixRule134(envelope));
        outcomes.Add(MatrixRule135(envelope));
        outcomes.Add(MatrixRule136(envelope));
        outcomes.Add(MatrixRule137(envelope));
        outcomes.Add(MatrixRule138(envelope));
        outcomes.Add(MatrixRule139(envelope));
        outcomes.Add(MatrixRule140(envelope));
        outcomes.Add(MatrixRule141(envelope));
        outcomes.Add(MatrixRule142(envelope));
        outcomes.Add(MatrixRule143(envelope));
        outcomes.Add(MatrixRule144(envelope));
        outcomes.Add(MatrixRule145(envelope));
        outcomes.Add(MatrixRule146(envelope));
        outcomes.Add(MatrixRule147(envelope));
        outcomes.Add(MatrixRule148(envelope));
        outcomes.Add(MatrixRule149(envelope));
        outcomes.Add(MatrixRule150(envelope));
        outcomes.Add(MatrixRule151(envelope));
        outcomes.Add(MatrixRule152(envelope));
        outcomes.Add(MatrixRule153(envelope));
        outcomes.Add(MatrixRule154(envelope));
        outcomes.Add(MatrixRule155(envelope));
        outcomes.Add(MatrixRule156(envelope));
        outcomes.Add(MatrixRule157(envelope));
        outcomes.Add(MatrixRule158(envelope));
        outcomes.Add(MatrixRule159(envelope));
        outcomes.Add(MatrixRule160(envelope));
        outcomes.Add(MatrixRule161(envelope));
        outcomes.Add(MatrixRule162(envelope));
        outcomes.Add(MatrixRule163(envelope));
        outcomes.Add(MatrixRule164(envelope));
        outcomes.Add(MatrixRule165(envelope));
        outcomes.Add(MatrixRule166(envelope));
        outcomes.Add(MatrixRule167(envelope));
        outcomes.Add(MatrixRule168(envelope));
        outcomes.Add(MatrixRule169(envelope));
        outcomes.Add(MatrixRule170(envelope));
        outcomes.Add(MatrixRule171(envelope));
        outcomes.Add(MatrixRule172(envelope));
        outcomes.Add(MatrixRule173(envelope));
        outcomes.Add(MatrixRule174(envelope));
        outcomes.Add(MatrixRule175(envelope));
        outcomes.Add(MatrixRule176(envelope));
        outcomes.Add(MatrixRule177(envelope));
        outcomes.Add(MatrixRule178(envelope));
        outcomes.Add(MatrixRule179(envelope));
        outcomes.Add(MatrixRule180(envelope));
        outcomes.Add(MatrixRule181(envelope));
        outcomes.Add(MatrixRule182(envelope));
        outcomes.Add(MatrixRule183(envelope));
        outcomes.Add(MatrixRule184(envelope));
        outcomes.Add(MatrixRule185(envelope));
        outcomes.Add(MatrixRule186(envelope));
        outcomes.Add(MatrixRule187(envelope));
        outcomes.Add(MatrixRule188(envelope));
        outcomes.Add(MatrixRule189(envelope));
        outcomes.Add(MatrixRule190(envelope));
        outcomes.Add(MatrixRule191(envelope));
        outcomes.Add(MatrixRule192(envelope));
        outcomes.Add(MatrixRule193(envelope));
        outcomes.Add(MatrixRule194(envelope));
        outcomes.Add(MatrixRule195(envelope));
        outcomes.Add(MatrixRule196(envelope));
        outcomes.Add(MatrixRule197(envelope));
        outcomes.Add(MatrixRule198(envelope));
        outcomes.Add(MatrixRule199(envelope));
        outcomes.Add(MatrixRule200(envelope));
        outcomes.Add(MatrixRule201(envelope));
        outcomes.Add(MatrixRule202(envelope));
        outcomes.Add(MatrixRule203(envelope));
        outcomes.Add(MatrixRule204(envelope));
        outcomes.Add(MatrixRule205(envelope));
        outcomes.Add(MatrixRule206(envelope));
        outcomes.Add(MatrixRule207(envelope));
        outcomes.Add(MatrixRule208(envelope));
        outcomes.Add(MatrixRule209(envelope));
        outcomes.Add(MatrixRule210(envelope));
        outcomes.Add(MatrixRule211(envelope));
        outcomes.Add(MatrixRule212(envelope));
        outcomes.Add(MatrixRule213(envelope));
        outcomes.Add(MatrixRule214(envelope));
        outcomes.Add(MatrixRule215(envelope));
        outcomes.Add(MatrixRule216(envelope));
        outcomes.Add(MatrixRule217(envelope));
        outcomes.Add(MatrixRule218(envelope));
        outcomes.Add(MatrixRule219(envelope));
        outcomes.Add(MatrixRule220(envelope));
        outcomes.Add(MatrixRule221(envelope));
        outcomes.Add(MatrixRule222(envelope));
        outcomes.Add(MatrixRule223(envelope));
        outcomes.Add(MatrixRule224(envelope));
        outcomes.Add(MatrixRule225(envelope));
        outcomes.Add(MatrixRule226(envelope));
        outcomes.Add(MatrixRule227(envelope));
        outcomes.Add(MatrixRule228(envelope));
        outcomes.Add(MatrixRule229(envelope));
        outcomes.Add(MatrixRule230(envelope));
        outcomes.Add(MatrixRule231(envelope));
        outcomes.Add(MatrixRule232(envelope));
        outcomes.Add(MatrixRule233(envelope));
        outcomes.Add(MatrixRule234(envelope));
        outcomes.Add(MatrixRule235(envelope));
        outcomes.Add(MatrixRule236(envelope));
        outcomes.Add(MatrixRule237(envelope));
        outcomes.Add(MatrixRule238(envelope));
        outcomes.Add(MatrixRule239(envelope));
        outcomes.Add(MatrixRule240(envelope));
        outcomes.Add(MatrixRule241(envelope));
        outcomes.Add(MatrixRule242(envelope));
        outcomes.Add(MatrixRule243(envelope));
        outcomes.Add(MatrixRule244(envelope));
        outcomes.Add(MatrixRule245(envelope));
        outcomes.Add(MatrixRule246(envelope));
        outcomes.Add(MatrixRule247(envelope));
        outcomes.Add(MatrixRule248(envelope));
        outcomes.Add(MatrixRule249(envelope));
        outcomes.Add(MatrixRule250(envelope));
        outcomes.Add(MatrixRule251(envelope));
        outcomes.Add(MatrixRule252(envelope));
        outcomes.Add(MatrixRule253(envelope));
        outcomes.Add(MatrixRule254(envelope));
        outcomes.Add(MatrixRule255(envelope));
        outcomes.Add(MatrixRule256(envelope));
        outcomes.Add(MatrixRule257(envelope));
        outcomes.Add(MatrixRule258(envelope));
        outcomes.Add(MatrixRule259(envelope));
        outcomes.Add(MatrixRule260(envelope));
        outcomes.Add(MatrixRule261(envelope));
        outcomes.Add(MatrixRule262(envelope));
        outcomes.Add(MatrixRule263(envelope));
        outcomes.Add(MatrixRule264(envelope));
        outcomes.Add(MatrixRule265(envelope));
        outcomes.Add(MatrixRule266(envelope));
        outcomes.Add(MatrixRule267(envelope));
        outcomes.Add(MatrixRule268(envelope));
        outcomes.Add(MatrixRule269(envelope));
        outcomes.Add(MatrixRule270(envelope));
        outcomes.Add(MatrixRule271(envelope));
        outcomes.Add(MatrixRule272(envelope));
        outcomes.Add(MatrixRule273(envelope));
        outcomes.Add(MatrixRule274(envelope));
        outcomes.Add(MatrixRule275(envelope));
        outcomes.Add(MatrixRule276(envelope));
        outcomes.Add(MatrixRule277(envelope));
        outcomes.Add(MatrixRule278(envelope));
        outcomes.Add(MatrixRule279(envelope));
        outcomes.Add(MatrixRule280(envelope));
        outcomes.Add(MatrixRule281(envelope));
        outcomes.Add(MatrixRule282(envelope));
        outcomes.Add(MatrixRule283(envelope));
        outcomes.Add(MatrixRule284(envelope));
        outcomes.Add(MatrixRule285(envelope));
        outcomes.Add(MatrixRule286(envelope));
        outcomes.Add(MatrixRule287(envelope));
        outcomes.Add(MatrixRule288(envelope));
        outcomes.Add(MatrixRule289(envelope));
        outcomes.Add(MatrixRule290(envelope));
        outcomes.Add(MatrixRule291(envelope));
        outcomes.Add(MatrixRule292(envelope));
        outcomes.Add(MatrixRule293(envelope));
        outcomes.Add(MatrixRule294(envelope));
        outcomes.Add(MatrixRule295(envelope));
        outcomes.Add(MatrixRule296(envelope));
        outcomes.Add(MatrixRule297(envelope));
        outcomes.Add(MatrixRule298(envelope));
        outcomes.Add(MatrixRule299(envelope));
        outcomes.Add(MatrixRule300(envelope));
        outcomes.Add(MatrixRule301(envelope));
        outcomes.Add(MatrixRule302(envelope));
        outcomes.Add(MatrixRule303(envelope));
        outcomes.Add(MatrixRule304(envelope));
        outcomes.Add(MatrixRule305(envelope));
        outcomes.Add(MatrixRule306(envelope));
        outcomes.Add(MatrixRule307(envelope));
        outcomes.Add(MatrixRule308(envelope));
        outcomes.Add(MatrixRule309(envelope));
        outcomes.Add(MatrixRule310(envelope));
        outcomes.Add(MatrixRule311(envelope));
        outcomes.Add(MatrixRule312(envelope));
        outcomes.Add(MatrixRule313(envelope));
        outcomes.Add(MatrixRule314(envelope));
        outcomes.Add(MatrixRule315(envelope));
        outcomes.Add(MatrixRule316(envelope));
        outcomes.Add(MatrixRule317(envelope));
        outcomes.Add(MatrixRule318(envelope));
        outcomes.Add(MatrixRule319(envelope));
        outcomes.Add(MatrixRule320(envelope));
        return outcomes;
    }

    private RuleOutcome MatrixRule1(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment1", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (1 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule1", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule2(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment2", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (2 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule2", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule3(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment3", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (3 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule3", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule4(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment4", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (4 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule4", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule5(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment5", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (5 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule5", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule6(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment6", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (6 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule6", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule7(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment7", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (7 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule7", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule8(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment8", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (8 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule8", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule9(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment9", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (9 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule9", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule10(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment10", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (10 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule10", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule11(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment11", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (11 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule11", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule12(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment12", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (12 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule12", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule13(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment13", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (13 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule13", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule14(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment14", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (14 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule14", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule15(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment15", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (15 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule15", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule16(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment16", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (16 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule16", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule17(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment17", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (17 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule17", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule18(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment18", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (18 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule18", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule19(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment19", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (19 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule19", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule20(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment20", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (20 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule20", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule21(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment21", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (21 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule21", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule22(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment22", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (22 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule22", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule23(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment23", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (23 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule23", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule24(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment24", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (24 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule24", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule25(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment25", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (25 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule25", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule26(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment26", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (26 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule26", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule27(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment27", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (27 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule27", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule28(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment28", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (28 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule28", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule29(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment29", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (29 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule29", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule30(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment30", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (30 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule30", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule31(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment31", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (31 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule31", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule32(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment32", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (32 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule32", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule33(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment33", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (33 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule33", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule34(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment34", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (34 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule34", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule35(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment35", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (35 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule35", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule36(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment36", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (36 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule36", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule37(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment37", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (37 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule37", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule38(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment38", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (38 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule38", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule39(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment39", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (39 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule39", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule40(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment40", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (40 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule40", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule41(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment41", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (41 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule41", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule42(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment42", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (42 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule42", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule43(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment43", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (43 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule43", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule44(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment44", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (44 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule44", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule45(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment45", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (45 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule45", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule46(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment46", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (46 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule46", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule47(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment47", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (47 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule47", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule48(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment48", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (48 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule48", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule49(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment49", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (49 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule49", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule50(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment50", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (50 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule50", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule51(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment51", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (51 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule51", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule52(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment52", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (52 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule52", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule53(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment53", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (53 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule53", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule54(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment54", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (54 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule54", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule55(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment55", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (55 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule55", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule56(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment56", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (56 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule56", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule57(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment57", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (57 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule57", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule58(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment58", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (58 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule58", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule59(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment59", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (59 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule59", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule60(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment60", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (60 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule60", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule61(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment61", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (61 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule61", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule62(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment62", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (62 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule62", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule63(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment63", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (63 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule63", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule64(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment64", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (64 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule64", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule65(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment65", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (65 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule65", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule66(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment66", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (66 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule66", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule67(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment67", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (67 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule67", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule68(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment68", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (68 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule68", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule69(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment69", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (69 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule69", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule70(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment70", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (70 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule70", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule71(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment71", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (71 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule71", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule72(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment72", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (72 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule72", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule73(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment73", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (73 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule73", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule74(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment74", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (74 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule74", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule75(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment75", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (75 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule75", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule76(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment76", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (76 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule76", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule77(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment77", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (77 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule77", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule78(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment78", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (78 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule78", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule79(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment79", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (79 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule79", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule80(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment80", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (80 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule80", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule81(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment81", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (81 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule81", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule82(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment82", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (82 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule82", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule83(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment83", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (83 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule83", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule84(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment84", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (84 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule84", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule85(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment85", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (85 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule85", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule86(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment86", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (86 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule86", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule87(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment87", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (87 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule87", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule88(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment88", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (88 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule88", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule89(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment89", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (89 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule89", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule90(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment90", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (90 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule90", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule91(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment91", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (91 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule91", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule92(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment92", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (92 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule92", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule93(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment93", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (93 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule93", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule94(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment94", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (94 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule94", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule95(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment95", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (95 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule95", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule96(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment96", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (96 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule96", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule97(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment97", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (97 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule97", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule98(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment98", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (98 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule98", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule99(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment99", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (99 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule99", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule100(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment100", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (100 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule100", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule101(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment101", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (101 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule101", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule102(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment102", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (102 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule102", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule103(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment103", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (103 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule103", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule104(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment104", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (104 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule104", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule105(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment105", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (105 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule105", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule106(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment106", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (106 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule106", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule107(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment107", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (107 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule107", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule108(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment108", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (108 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule108", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule109(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment109", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (109 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule109", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule110(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment110", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (110 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule110", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule111(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment111", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (111 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule111", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule112(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment112", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (112 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule112", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule113(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment113", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (113 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule113", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule114(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment114", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (114 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule114", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule115(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment115", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (115 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule115", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule116(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment116", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (116 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule116", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule117(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment117", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (117 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule117", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule118(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment118", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (118 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule118", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule119(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment119", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (119 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule119", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule120(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment120", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (120 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule120", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule121(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment121", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (121 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule121", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule122(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment122", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (122 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule122", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule123(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment123", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (123 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule123", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule124(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment124", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (124 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule124", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule125(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment125", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (125 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule125", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule126(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment126", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (126 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule126", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule127(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment127", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (127 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule127", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule128(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment128", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (128 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule128", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule129(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment129", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (129 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule129", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule130(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment130", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (130 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule130", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule131(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment131", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (131 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule131", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule132(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment132", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (132 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule132", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule133(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment133", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (133 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule133", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule134(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment134", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (134 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule134", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule135(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment135", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (135 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule135", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule136(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment136", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (136 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule136", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule137(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment137", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (137 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule137", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule138(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment138", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (138 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule138", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule139(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment139", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (139 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule139", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule140(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment140", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (140 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule140", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule141(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment141", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (141 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule141", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule142(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment142", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (142 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule142", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule143(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment143", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (143 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule143", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule144(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment144", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (144 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule144", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule145(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment145", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (145 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule145", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule146(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment146", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (146 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule146", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule147(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment147", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (147 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule147", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule148(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment148", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (148 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule148", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule149(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment149", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (149 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule149", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule150(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment150", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (150 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule150", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule151(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment151", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (151 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule151", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule152(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment152", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (152 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule152", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule153(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment153", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (153 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule153", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule154(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment154", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (154 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule154", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule155(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment155", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (155 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule155", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule156(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment156", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (156 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule156", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule157(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment157", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (157 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule157", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule158(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment158", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (158 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule158", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule159(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment159", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (159 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule159", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule160(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment160", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (160 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule160", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule161(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment161", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (161 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule161", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule162(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment162", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (162 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule162", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule163(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment163", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (163 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule163", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule164(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment164", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (164 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule164", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule165(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment165", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (165 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule165", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule166(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment166", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (166 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule166", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule167(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment167", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (167 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule167", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule168(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment168", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (168 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule168", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule169(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment169", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (169 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule169", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule170(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment170", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (170 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule170", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule171(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment171", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (171 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule171", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule172(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment172", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (172 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule172", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule173(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment173", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (173 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule173", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule174(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment174", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (174 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule174", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule175(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment175", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (175 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule175", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule176(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment176", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (176 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule176", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule177(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment177", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (177 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule177", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule178(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment178", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (178 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule178", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule179(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment179", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (179 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule179", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule180(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment180", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (180 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule180", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule181(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment181", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (181 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule181", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule182(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment182", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (182 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule182", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule183(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment183", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (183 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule183", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule184(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment184", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (184 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule184", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule185(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment185", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (185 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule185", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule186(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment186", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (186 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule186", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule187(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment187", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (187 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule187", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule188(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment188", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (188 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule188", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule189(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment189", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (189 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule189", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule190(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment190", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (190 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule190", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule191(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment191", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (191 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule191", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule192(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment192", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (192 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule192", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule193(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment193", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (193 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule193", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule194(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment194", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (194 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule194", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule195(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment195", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (195 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule195", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule196(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment196", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (196 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule196", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule197(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment197", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (197 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule197", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule198(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment198", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (198 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule198", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule199(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment199", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (199 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule199", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule200(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment200", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (200 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule200", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule201(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment201", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (201 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule201", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule202(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment202", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (202 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule202", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule203(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment203", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (203 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule203", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule204(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment204", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (204 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule204", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule205(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment205", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (205 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule205", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule206(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment206", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (206 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule206", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule207(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment207", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (207 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule207", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule208(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment208", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (208 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule208", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule209(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment209", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (209 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule209", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule210(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment210", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (210 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule210", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule211(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment211", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (211 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule211", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule212(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment212", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (212 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule212", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule213(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment213", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (213 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule213", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule214(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment214", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (214 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule214", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule215(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment215", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (215 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule215", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule216(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment216", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (216 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule216", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule217(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment217", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (217 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule217", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule218(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment218", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (218 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule218", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule219(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment219", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (219 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule219", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule220(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment220", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (220 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule220", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule221(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment221", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (221 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule221", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule222(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment222", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (222 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule222", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule223(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment223", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (223 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule223", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule224(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment224", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (224 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule224", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule225(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment225", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (225 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule225", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule226(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment226", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (226 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule226", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule227(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment227", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (227 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule227", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule228(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment228", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (228 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule228", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule229(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment229", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (229 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule229", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule230(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment230", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (230 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule230", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule231(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment231", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (231 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule231", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule232(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment232", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (232 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule232", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule233(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment233", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (233 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule233", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule234(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment234", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (234 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule234", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule235(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment235", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (235 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule235", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule236(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment236", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (236 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule236", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule237(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment237", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (237 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule237", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule238(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment238", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (238 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule238", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule239(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment239", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (239 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule239", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule240(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment240", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (240 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule240", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule241(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment241", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (241 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule241", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule242(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment242", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (242 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule242", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule243(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment243", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (243 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule243", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule244(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment244", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (244 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule244", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule245(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment245", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (245 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule245", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule246(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment246", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (246 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule246", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule247(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment247", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (247 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule247", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule248(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment248", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (248 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule248", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule249(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment249", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (249 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule249", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule250(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment250", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (250 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule250", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule251(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment251", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (251 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule251", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule252(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment252", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (252 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule252", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule253(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment253", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (253 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule253", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule254(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment254", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (254 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule254", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule255(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment255", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (255 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule255", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule256(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment256", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (256 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule256", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule257(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment257", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (257 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule257", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule258(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment258", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (258 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule258", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule259(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment259", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (259 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule259", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule260(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment260", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (260 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule260", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule261(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment261", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (261 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule261", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule262(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment262", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (262 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule262", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule263(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment263", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (263 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule263", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule264(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment264", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (264 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule264", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule265(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment265", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (265 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule265", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule266(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment266", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (266 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule266", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule267(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment267", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (267 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule267", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule268(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment268", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (268 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule268", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule269(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment269", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (269 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule269", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule270(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment270", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (270 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule270", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule271(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment271", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (271 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule271", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule272(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment272", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (272 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule272", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule273(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment273", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (273 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule273", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule274(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment274", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (274 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule274", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule275(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment275", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (275 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule275", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule276(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment276", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (276 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule276", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule277(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment277", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (277 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule277", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule278(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment278", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (278 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule278", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule279(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment279", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (279 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule279", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule280(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment280", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (280 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule280", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule281(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment281", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (281 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule281", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule282(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment282", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (282 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule282", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule283(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment283", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (283 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule283", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule284(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment284", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (284 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule284", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule285(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment285", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (285 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule285", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule286(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment286", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (286 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule286", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule287(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment287", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (287 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule287", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule288(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment288", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (288 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule288", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule289(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment289", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (289 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule289", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule290(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment290", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (290 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule290", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule291(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment291", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (291 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule291", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule292(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment292", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (292 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule292", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule293(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment293", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (293 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule293", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule294(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment294", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (294 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule294", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule295(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment295", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (295 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule295", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule296(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment296", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (296 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule296", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule297(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment297", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (297 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule297", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule298(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment298", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (298 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule298", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule299(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment299", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (299 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule299", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule300(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment300", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (300 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule300", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule301(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment301", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (301 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule301", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule302(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment302", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (302 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule302", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule303(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment303", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (303 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule303", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule304(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment304", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (304 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule304", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule305(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment305", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (305 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule305", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule306(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment306", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (306 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule306", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule307(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment307", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (307 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule307", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule308(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment308", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (308 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule308", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule309(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment309", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (309 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule309", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule310(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment310", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (310 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule310", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule311(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment311", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (311 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule311", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule312(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment312", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (312 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule312", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule313(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment313", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (313 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule313", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule314(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment314", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (314 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule314", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule315(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment315", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (315 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule315", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule316(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment316", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (316 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule316", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule317(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment317", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (317 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule317", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule318(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment318", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (318 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule318", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule319(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment319", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (319 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule319", flagged, evidence, score, classification);
    }

    private RuleOutcome MatrixRule320(PayloadEnvelope envelope)
    {
        var routeHint = _gateway.BuildRouteHint(envelope);
        var storageCandidate = _gateway.BuildStorageCandidate(envelope);
        var query = _repository.BuildQueryText(envelope.Tenant, "segment320", envelope.RequestId);
        var tokenCount = _gateway.CountSuspiciousTokens(envelope);
        var weighted = tokenCount + (320 % 11);
        var executable = _gateway.LooksExecutable(envelope);
        var traversal = _repository.LooksLikeTraversal(storageCandidate);
        var hasTemplate = _gateway.HasTemplateMarkers(envelope);
        var callback = _gateway.BuildExternalCallback(envelope);
        var flagged = executable || traversal || hasTemplate || weighted > 5;
        var evidence = "route=" + routeHint + ";candidate=" + storageCandidate + ";query=" + query + ";callback=" + callback;
        var score = flagged ? weighted + 3 : weighted;
        var classification = flagged ? "extended-review" : "baseline";
        return new RuleOutcome("MatrixRule320", flagged, evidence, score, classification);
    }

}

