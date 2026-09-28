//HintName: G.Models.ToolControllerCreateRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolControllerCreateRequest : global::System.IEquatable<ToolControllerCreateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolControllerCreateRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateApiRequestToolDTO? ApiRequest { get; init; }
#else
        public global::G.CreateApiRequestToolDTO? ApiRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiRequest))]
#endif
        public bool IsApiRequest => ApiRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApiRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateApiRequestToolDTO? value)
        {
            value = ApiRequest;
            return IsApiRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateApiRequestToolDTO PickApiRequest() => ApiRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiRequest' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateCodeToolDTO? Code { get; init; }
#else
        public global::G.CreateCodeToolDTO? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateCodeToolDTO? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateCodeToolDTO PickCode() => Code is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateDtmfToolDTO? Dtmf { get; init; }
#else
        public global::G.CreateDtmfToolDTO? Dtmf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dtmf))]
#endif
        public bool IsDtmf => Dtmf != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDtmf(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateDtmfToolDTO? value)
        {
            value = Dtmf;
            return IsDtmf;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateDtmfToolDTO PickDtmf() => Dtmf is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dtmf' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateEndCallToolDTO? EndCall { get; init; }
#else
        public global::G.CreateEndCallToolDTO? EndCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndCall))]
#endif
        public bool IsEndCall => EndCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEndCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateEndCallToolDTO? value)
        {
            value = EndCall;
            return IsEndCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateEndCallToolDTO PickEndCall() => EndCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndCall' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateFunctionToolDTO? Function { get; init; }
#else
        public global::G.CreateFunctionToolDTO? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateFunctionToolDTO? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateFunctionToolDTO PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTransferCallToolDTO? TransferCall { get; init; }
#else
        public global::G.CreateTransferCallToolDTO? TransferCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferCall))]
#endif
        public bool IsTransferCall => TransferCall != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTransferCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateTransferCallToolDTO? value)
        {
            value = TransferCall;
            return IsTransferCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTransferCallToolDTO PickTransferCall() => TransferCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransferCall' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateHandoffToolDTO? Handoff { get; init; }
#else
        public global::G.CreateHandoffToolDTO? Handoff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Handoff))]
#endif
        public bool IsHandoff => Handoff != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHandoff(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateHandoffToolDTO? value)
        {
            value = Handoff;
            return IsHandoff;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateHandoffToolDTO PickHandoff() => Handoff is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Handoff' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateBashToolDTO? Bash { get; init; }
#else
        public global::G.CreateBashToolDTO? Bash { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bash))]
#endif
        public bool IsBash => Bash != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateBashToolDTO? value)
        {
            value = Bash;
            return IsBash;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateBashToolDTO PickBash() => Bash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bash' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateComputerToolDTO? Computer { get; init; }
#else
        public global::G.CreateComputerToolDTO? Computer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer))]
#endif
        public bool IsComputer => Computer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickComputer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateComputerToolDTO? value)
        {
            value = Computer;
            return IsComputer;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateComputerToolDTO PickComputer() => Computer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Computer' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateTextEditorToolDTO? TextEditor { get; init; }
#else
        public global::G.CreateTextEditorToolDTO? TextEditor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor))]
#endif
        public bool IsTextEditor => TextEditor != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextEditor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateTextEditorToolDTO? value)
        {
            value = TextEditor;
            return IsTextEditor;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateTextEditorToolDTO PickTextEditor() => TextEditor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateQueryToolDTO? Query { get; init; }
#else
        public global::G.CreateQueryToolDTO? Query { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Query))]
#endif
        public bool IsQuery => Query != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickQuery(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateQueryToolDTO? value)
        {
            value = Query;
            return IsQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateQueryToolDTO PickQuery() => Query is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Query' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoogleCalendarCreateEventToolDTO? GoogleCalendarEventCreate { get; init; }
#else
        public global::G.CreateGoogleCalendarCreateEventToolDTO? GoogleCalendarEventCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleCalendarEventCreate))]
#endif
        public bool IsGoogleCalendarEventCreate => GoogleCalendarEventCreate != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleCalendarEventCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoogleCalendarCreateEventToolDTO? value)
        {
            value = GoogleCalendarEventCreate;
            return IsGoogleCalendarEventCreate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoogleCalendarCreateEventToolDTO PickGoogleCalendarEventCreate() => GoogleCalendarEventCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleCalendarEventCreate' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoogleSheetsRowAppendToolDTO? GoogleSheetsRowAppend { get; init; }
#else
        public global::G.CreateGoogleSheetsRowAppendToolDTO? GoogleSheetsRowAppend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleSheetsRowAppend))]
#endif
        public bool IsGoogleSheetsRowAppend => GoogleSheetsRowAppend != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleSheetsRowAppend(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoogleSheetsRowAppendToolDTO? value)
        {
            value = GoogleSheetsRowAppend;
            return IsGoogleSheetsRowAppend;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoogleSheetsRowAppendToolDTO PickGoogleSheetsRowAppend() => GoogleSheetsRowAppend is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleSheetsRowAppend' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoogleCalendarCheckAvailabilityToolDTO? GoogleCalendarAvailabilityCheck { get; init; }
#else
        public global::G.CreateGoogleCalendarCheckAvailabilityToolDTO? GoogleCalendarAvailabilityCheck { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleCalendarAvailabilityCheck))]
#endif
        public bool IsGoogleCalendarAvailabilityCheck => GoogleCalendarAvailabilityCheck != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleCalendarAvailabilityCheck(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoogleCalendarCheckAvailabilityToolDTO? value)
        {
            value = GoogleCalendarAvailabilityCheck;
            return IsGoogleCalendarAvailabilityCheck;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoogleCalendarCheckAvailabilityToolDTO PickGoogleCalendarAvailabilityCheck() => GoogleCalendarAvailabilityCheck is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleCalendarAvailabilityCheck' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSlackSendMessageToolDTO? SlackMessageSend { get; init; }
#else
        public global::G.CreateSlackSendMessageToolDTO? SlackMessageSend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackMessageSend))]
#endif
        public bool IsSlackMessageSend => SlackMessageSend != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSlackMessageSend(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateSlackSendMessageToolDTO? value)
        {
            value = SlackMessageSend;
            return IsSlackMessageSend;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSlackSendMessageToolDTO PickSlackMessageSend() => SlackMessageSend is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackMessageSend' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSmsToolDTO? Sms { get; init; }
#else
        public global::G.CreateSmsToolDTO? Sms { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sms))]
#endif
        public bool IsSms => Sms != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSms(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateSmsToolDTO? value)
        {
            value = Sms;
            return IsSms;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSmsToolDTO PickSms() => Sms is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sms' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateMcpToolDTO? Mcp { get; init; }
#else
        public global::G.CreateMcpToolDTO? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateMcpToolDTO? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMcpToolDTO PickMcp() => Mcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoHighLevelCalendarAvailabilityToolDTO? GohighlevelCalendarAvailabilityCheck { get; init; }
#else
        public global::G.CreateGoHighLevelCalendarAvailabilityToolDTO? GohighlevelCalendarAvailabilityCheck { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GohighlevelCalendarAvailabilityCheck))]
#endif
        public bool IsGohighlevelCalendarAvailabilityCheck => GohighlevelCalendarAvailabilityCheck != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGohighlevelCalendarAvailabilityCheck(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoHighLevelCalendarAvailabilityToolDTO? value)
        {
            value = GohighlevelCalendarAvailabilityCheck;
            return IsGohighlevelCalendarAvailabilityCheck;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoHighLevelCalendarAvailabilityToolDTO PickGohighlevelCalendarAvailabilityCheck() => GohighlevelCalendarAvailabilityCheck is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GohighlevelCalendarAvailabilityCheck' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoHighLevelCalendarEventCreateToolDTO? GohighlevelCalendarEventCreate { get; init; }
#else
        public global::G.CreateGoHighLevelCalendarEventCreateToolDTO? GohighlevelCalendarEventCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GohighlevelCalendarEventCreate))]
#endif
        public bool IsGohighlevelCalendarEventCreate => GohighlevelCalendarEventCreate != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGohighlevelCalendarEventCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoHighLevelCalendarEventCreateToolDTO? value)
        {
            value = GohighlevelCalendarEventCreate;
            return IsGohighlevelCalendarEventCreate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoHighLevelCalendarEventCreateToolDTO PickGohighlevelCalendarEventCreate() => GohighlevelCalendarEventCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GohighlevelCalendarEventCreate' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoHighLevelContactCreateToolDTO? GohighlevelContactCreate { get; init; }
#else
        public global::G.CreateGoHighLevelContactCreateToolDTO? GohighlevelContactCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GohighlevelContactCreate))]
#endif
        public bool IsGohighlevelContactCreate => GohighlevelContactCreate != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGohighlevelContactCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoHighLevelContactCreateToolDTO? value)
        {
            value = GohighlevelContactCreate;
            return IsGohighlevelContactCreate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoHighLevelContactCreateToolDTO PickGohighlevelContactCreate() => GohighlevelContactCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GohighlevelContactCreate' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateGoHighLevelContactGetToolDTO? GohighlevelContactGet { get; init; }
#else
        public global::G.CreateGoHighLevelContactGetToolDTO? GohighlevelContactGet { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GohighlevelContactGet))]
#endif
        public bool IsGohighlevelContactGet => GohighlevelContactGet != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGohighlevelContactGet(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateGoHighLevelContactGetToolDTO? value)
        {
            value = GohighlevelContactGet;
            return IsGohighlevelContactGet;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateGoHighLevelContactGetToolDTO PickGohighlevelContactGet() => GohighlevelContactGet is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GohighlevelContactGet' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSipRequestToolDTO? SipRequest { get; init; }
#else
        public global::G.CreateSipRequestToolDTO? SipRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipRequest))]
#endif
        public bool IsSipRequest => SipRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSipRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateSipRequestToolDTO? value)
        {
            value = SipRequest;
            return IsSipRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateSipRequestToolDTO PickSipRequest() => SipRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipRequest' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateVoicemailToolDTO? Voicemail { get; init; }
#else
        public global::G.CreateVoicemailToolDTO? Voicemail { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Voicemail))]
#endif
        public bool IsVoicemail => Voicemail != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVoicemail(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.CreateVoicemailToolDTO? value)
        {
            value = Voicemail;
            return IsVoicemail;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateVoicemailToolDTO PickVoicemail() => Voicemail is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Voicemail' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateApiRequestToolDTO value) => new ToolControllerCreateRequest((global::G.CreateApiRequestToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateApiRequestToolDTO?(ToolControllerCreateRequest @this) => @this.ApiRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateApiRequestToolDTO? value)
        {
            ApiRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromApiRequest(global::G.CreateApiRequestToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateCodeToolDTO value) => new ToolControllerCreateRequest((global::G.CreateCodeToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateCodeToolDTO?(ToolControllerCreateRequest @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateCodeToolDTO? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromCode(global::G.CreateCodeToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateDtmfToolDTO value) => new ToolControllerCreateRequest((global::G.CreateDtmfToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateDtmfToolDTO?(ToolControllerCreateRequest @this) => @this.Dtmf;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateDtmfToolDTO? value)
        {
            Dtmf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromDtmf(global::G.CreateDtmfToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateEndCallToolDTO value) => new ToolControllerCreateRequest((global::G.CreateEndCallToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateEndCallToolDTO?(ToolControllerCreateRequest @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateEndCallToolDTO? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromEndCall(global::G.CreateEndCallToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateFunctionToolDTO value) => new ToolControllerCreateRequest((global::G.CreateFunctionToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateFunctionToolDTO?(ToolControllerCreateRequest @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateFunctionToolDTO? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromFunction(global::G.CreateFunctionToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateTransferCallToolDTO value) => new ToolControllerCreateRequest((global::G.CreateTransferCallToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTransferCallToolDTO?(ToolControllerCreateRequest @this) => @this.TransferCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateTransferCallToolDTO? value)
        {
            TransferCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromTransferCall(global::G.CreateTransferCallToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateHandoffToolDTO value) => new ToolControllerCreateRequest((global::G.CreateHandoffToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateHandoffToolDTO?(ToolControllerCreateRequest @this) => @this.Handoff;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateHandoffToolDTO? value)
        {
            Handoff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromHandoff(global::G.CreateHandoffToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateBashToolDTO value) => new ToolControllerCreateRequest((global::G.CreateBashToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateBashToolDTO?(ToolControllerCreateRequest @this) => @this.Bash;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateBashToolDTO? value)
        {
            Bash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromBash(global::G.CreateBashToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateComputerToolDTO value) => new ToolControllerCreateRequest((global::G.CreateComputerToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateComputerToolDTO?(ToolControllerCreateRequest @this) => @this.Computer;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateComputerToolDTO? value)
        {
            Computer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromComputer(global::G.CreateComputerToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateTextEditorToolDTO value) => new ToolControllerCreateRequest((global::G.CreateTextEditorToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTextEditorToolDTO?(ToolControllerCreateRequest @this) => @this.TextEditor;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateTextEditorToolDTO? value)
        {
            TextEditor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromTextEditor(global::G.CreateTextEditorToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateQueryToolDTO value) => new ToolControllerCreateRequest((global::G.CreateQueryToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateQueryToolDTO?(ToolControllerCreateRequest @this) => @this.Query;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateQueryToolDTO? value)
        {
            Query = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromQuery(global::G.CreateQueryToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateGoogleCalendarCreateEventToolDTO value) => new ToolControllerCreateRequest((global::G.CreateGoogleCalendarCreateEventToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoogleCalendarCreateEventToolDTO?(ToolControllerCreateRequest @this) => @this.GoogleCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateGoogleCalendarCreateEventToolDTO? value)
        {
            GoogleCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromGoogleCalendarEventCreate(global::G.CreateGoogleCalendarCreateEventToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateGoogleSheetsRowAppendToolDTO value) => new ToolControllerCreateRequest((global::G.CreateGoogleSheetsRowAppendToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoogleSheetsRowAppendToolDTO?(ToolControllerCreateRequest @this) => @this.GoogleSheetsRowAppend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateGoogleSheetsRowAppendToolDTO? value)
        {
            GoogleSheetsRowAppend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromGoogleSheetsRowAppend(global::G.CreateGoogleSheetsRowAppendToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateGoogleCalendarCheckAvailabilityToolDTO value) => new ToolControllerCreateRequest((global::G.CreateGoogleCalendarCheckAvailabilityToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoogleCalendarCheckAvailabilityToolDTO?(ToolControllerCreateRequest @this) => @this.GoogleCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateGoogleCalendarCheckAvailabilityToolDTO? value)
        {
            GoogleCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromGoogleCalendarAvailabilityCheck(global::G.CreateGoogleCalendarCheckAvailabilityToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateSlackSendMessageToolDTO value) => new ToolControllerCreateRequest((global::G.CreateSlackSendMessageToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSlackSendMessageToolDTO?(ToolControllerCreateRequest @this) => @this.SlackMessageSend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateSlackSendMessageToolDTO? value)
        {
            SlackMessageSend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromSlackMessageSend(global::G.CreateSlackSendMessageToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateSmsToolDTO value) => new ToolControllerCreateRequest((global::G.CreateSmsToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSmsToolDTO?(ToolControllerCreateRequest @this) => @this.Sms;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateSmsToolDTO? value)
        {
            Sms = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromSms(global::G.CreateSmsToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateMcpToolDTO value) => new ToolControllerCreateRequest((global::G.CreateMcpToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateMcpToolDTO?(ToolControllerCreateRequest @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateMcpToolDTO? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromMcp(global::G.CreateMcpToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateGoHighLevelCalendarAvailabilityToolDTO value) => new ToolControllerCreateRequest((global::G.CreateGoHighLevelCalendarAvailabilityToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoHighLevelCalendarAvailabilityToolDTO?(ToolControllerCreateRequest @this) => @this.GohighlevelCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateGoHighLevelCalendarAvailabilityToolDTO? value)
        {
            GohighlevelCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromGohighlevelCalendarAvailabilityCheck(global::G.CreateGoHighLevelCalendarAvailabilityToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateGoHighLevelCalendarEventCreateToolDTO value) => new ToolControllerCreateRequest((global::G.CreateGoHighLevelCalendarEventCreateToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoHighLevelCalendarEventCreateToolDTO?(ToolControllerCreateRequest @this) => @this.GohighlevelCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateGoHighLevelCalendarEventCreateToolDTO? value)
        {
            GohighlevelCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromGohighlevelCalendarEventCreate(global::G.CreateGoHighLevelCalendarEventCreateToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateGoHighLevelContactCreateToolDTO value) => new ToolControllerCreateRequest((global::G.CreateGoHighLevelContactCreateToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoHighLevelContactCreateToolDTO?(ToolControllerCreateRequest @this) => @this.GohighlevelContactCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateGoHighLevelContactCreateToolDTO? value)
        {
            GohighlevelContactCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromGohighlevelContactCreate(global::G.CreateGoHighLevelContactCreateToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateGoHighLevelContactGetToolDTO value) => new ToolControllerCreateRequest((global::G.CreateGoHighLevelContactGetToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateGoHighLevelContactGetToolDTO?(ToolControllerCreateRequest @this) => @this.GohighlevelContactGet;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateGoHighLevelContactGetToolDTO? value)
        {
            GohighlevelContactGet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromGohighlevelContactGet(global::G.CreateGoHighLevelContactGetToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateSipRequestToolDTO value) => new ToolControllerCreateRequest((global::G.CreateSipRequestToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSipRequestToolDTO?(ToolControllerCreateRequest @this) => @this.SipRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateSipRequestToolDTO? value)
        {
            SipRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromSipRequest(global::G.CreateSipRequestToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::G.CreateVoicemailToolDTO value) => new ToolControllerCreateRequest((global::G.CreateVoicemailToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateVoicemailToolDTO?(ToolControllerCreateRequest @this) => @this.Voicemail;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::G.CreateVoicemailToolDTO? value)
        {
            Voicemail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolControllerCreateRequest FromVoicemail(global::G.CreateVoicemailToolDTO? value) => new ToolControllerCreateRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(
            global::G.ToolControllerCreateRequestDiscriminatorType? type,
            global::G.CreateApiRequestToolDTO? apiRequest,
            global::G.CreateCodeToolDTO? code,
            global::G.CreateDtmfToolDTO? dtmf,
            global::G.CreateEndCallToolDTO? endCall,
            global::G.CreateFunctionToolDTO? function,
            global::G.CreateTransferCallToolDTO? transferCall,
            global::G.CreateHandoffToolDTO? handoff,
            global::G.CreateBashToolDTO? bash,
            global::G.CreateComputerToolDTO? computer,
            global::G.CreateTextEditorToolDTO? textEditor,
            global::G.CreateQueryToolDTO? query,
            global::G.CreateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate,
            global::G.CreateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend,
            global::G.CreateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck,
            global::G.CreateSlackSendMessageToolDTO? slackMessageSend,
            global::G.CreateSmsToolDTO? sms,
            global::G.CreateMcpToolDTO? mcp,
            global::G.CreateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck,
            global::G.CreateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate,
            global::G.CreateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate,
            global::G.CreateGoHighLevelContactGetToolDTO? gohighlevelContactGet,
            global::G.CreateSipRequestToolDTO? sipRequest,
            global::G.CreateVoicemailToolDTO? voicemail
            )
        {
            Type = type;

            ApiRequest = apiRequest;
            Code = code;
            Dtmf = dtmf;
            EndCall = endCall;
            Function = function;
            TransferCall = transferCall;
            Handoff = handoff;
            Bash = bash;
            Computer = computer;
            TextEditor = textEditor;
            Query = query;
            GoogleCalendarEventCreate = googleCalendarEventCreate;
            GoogleSheetsRowAppend = googleSheetsRowAppend;
            GoogleCalendarAvailabilityCheck = googleCalendarAvailabilityCheck;
            SlackMessageSend = slackMessageSend;
            Sms = sms;
            Mcp = mcp;
            GohighlevelCalendarAvailabilityCheck = gohighlevelCalendarAvailabilityCheck;
            GohighlevelCalendarEventCreate = gohighlevelCalendarEventCreate;
            GohighlevelContactCreate = gohighlevelContactCreate;
            GohighlevelContactGet = gohighlevelContactGet;
            SipRequest = sipRequest;
            Voicemail = voicemail;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Voicemail as object ??
            SipRequest as object ??
            GohighlevelContactGet as object ??
            GohighlevelContactCreate as object ??
            GohighlevelCalendarEventCreate as object ??
            GohighlevelCalendarAvailabilityCheck as object ??
            Mcp as object ??
            Sms as object ??
            SlackMessageSend as object ??
            GoogleCalendarAvailabilityCheck as object ??
            GoogleSheetsRowAppend as object ??
            GoogleCalendarEventCreate as object ??
            Query as object ??
            TextEditor as object ??
            Computer as object ??
            Bash as object ??
            Handoff as object ??
            TransferCall as object ??
            Function as object ??
            EndCall as object ??
            Dtmf as object ??
            Code as object ??
            ApiRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApiRequest?.ToString() ??
            Code?.ToString() ??
            Dtmf?.ToString() ??
            EndCall?.ToString() ??
            Function?.ToString() ??
            TransferCall?.ToString() ??
            Handoff?.ToString() ??
            Bash?.ToString() ??
            Computer?.ToString() ??
            TextEditor?.ToString() ??
            Query?.ToString() ??
            GoogleCalendarEventCreate?.ToString() ??
            GoogleSheetsRowAppend?.ToString() ??
            GoogleCalendarAvailabilityCheck?.ToString() ??
            SlackMessageSend?.ToString() ??
            Sms?.ToString() ??
            Mcp?.ToString() ??
            GohighlevelCalendarAvailabilityCheck?.ToString() ??
            GohighlevelCalendarEventCreate?.ToString() ??
            GohighlevelContactCreate?.ToString() ??
            GohighlevelContactGet?.ToString() ??
            SipRequest?.ToString() ??
            Voicemail?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && IsVoicemail;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateApiRequestToolDTO, TResult>? apiRequest = null,
            global::System.Func<global::G.CreateCodeToolDTO, TResult>? code = null,
            global::System.Func<global::G.CreateDtmfToolDTO, TResult>? dtmf = null,
            global::System.Func<global::G.CreateEndCallToolDTO, TResult>? endCall = null,
            global::System.Func<global::G.CreateFunctionToolDTO, TResult>? function = null,
            global::System.Func<global::G.CreateTransferCallToolDTO, TResult>? transferCall = null,
            global::System.Func<global::G.CreateHandoffToolDTO, TResult>? handoff = null,
            global::System.Func<global::G.CreateBashToolDTO, TResult>? bash = null,
            global::System.Func<global::G.CreateComputerToolDTO, TResult>? computer = null,
            global::System.Func<global::G.CreateTextEditorToolDTO, TResult>? textEditor = null,
            global::System.Func<global::G.CreateQueryToolDTO, TResult>? query = null,
            global::System.Func<global::G.CreateGoogleCalendarCreateEventToolDTO, TResult>? googleCalendarEventCreate = null,
            global::System.Func<global::G.CreateGoogleSheetsRowAppendToolDTO, TResult>? googleSheetsRowAppend = null,
            global::System.Func<global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, TResult>? googleCalendarAvailabilityCheck = null,
            global::System.Func<global::G.CreateSlackSendMessageToolDTO, TResult>? slackMessageSend = null,
            global::System.Func<global::G.CreateSmsToolDTO, TResult>? sms = null,
            global::System.Func<global::G.CreateMcpToolDTO, TResult>? mcp = null,
            global::System.Func<global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, TResult>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Func<global::G.CreateGoHighLevelCalendarEventCreateToolDTO, TResult>? gohighlevelCalendarEventCreate = null,
            global::System.Func<global::G.CreateGoHighLevelContactCreateToolDTO, TResult>? gohighlevelContactCreate = null,
            global::System.Func<global::G.CreateGoHighLevelContactGetToolDTO, TResult>? gohighlevelContactGet = null,
            global::System.Func<global::G.CreateSipRequestToolDTO, TResult>? sipRequest = null,
            global::System.Func<global::G.CreateVoicemailToolDTO, TResult>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ApiRequest is { } __value0 && apiRequest != null)
            {
                return apiRequest(__value0);
            }
            else if (Code is { } __value1 && code != null)
            {
                return code(__value1);
            }
            else if (Dtmf is { } __value2 && dtmf != null)
            {
                return dtmf(__value2);
            }
            else if (EndCall is { } __value3 && endCall != null)
            {
                return endCall(__value3);
            }
            else if (Function is { } __value4 && function != null)
            {
                return function(__value4);
            }
            else if (TransferCall is { } __value5 && transferCall != null)
            {
                return transferCall(__value5);
            }
            else if (Handoff is { } __value6 && handoff != null)
            {
                return handoff(__value6);
            }
            else if (Bash is { } __value7 && bash != null)
            {
                return bash(__value7);
            }
            else if (Computer is { } __value8 && computer != null)
            {
                return computer(__value8);
            }
            else if (TextEditor is { } __value9 && textEditor != null)
            {
                return textEditor(__value9);
            }
            else if (Query is { } __value10 && query != null)
            {
                return query(__value10);
            }
            else if (GoogleCalendarEventCreate is { } __value11 && googleCalendarEventCreate != null)
            {
                return googleCalendarEventCreate(__value11);
            }
            else if (GoogleSheetsRowAppend is { } __value12 && googleSheetsRowAppend != null)
            {
                return googleSheetsRowAppend(__value12);
            }
            else if (GoogleCalendarAvailabilityCheck is { } __value13 && googleCalendarAvailabilityCheck != null)
            {
                return googleCalendarAvailabilityCheck(__value13);
            }
            else if (SlackMessageSend is { } __value14 && slackMessageSend != null)
            {
                return slackMessageSend(__value14);
            }
            else if (Sms is { } __value15 && sms != null)
            {
                return sms(__value15);
            }
            else if (Mcp is { } __value16 && mcp != null)
            {
                return mcp(__value16);
            }
            else if (GohighlevelCalendarAvailabilityCheck is { } __value17 && gohighlevelCalendarAvailabilityCheck != null)
            {
                return gohighlevelCalendarAvailabilityCheck(__value17);
            }
            else if (GohighlevelCalendarEventCreate is { } __value18 && gohighlevelCalendarEventCreate != null)
            {
                return gohighlevelCalendarEventCreate(__value18);
            }
            else if (GohighlevelContactCreate is { } __value19 && gohighlevelContactCreate != null)
            {
                return gohighlevelContactCreate(__value19);
            }
            else if (GohighlevelContactGet is { } __value20 && gohighlevelContactGet != null)
            {
                return gohighlevelContactGet(__value20);
            }
            else if (SipRequest is { } __value21 && sipRequest != null)
            {
                return sipRequest(__value21);
            }
            else if (Voicemail is { } __value22 && voicemail != null)
            {
                return voicemail(__value22);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateApiRequestToolDTO>? apiRequest = null,

            global::System.Action<global::G.CreateCodeToolDTO>? code = null,

            global::System.Action<global::G.CreateDtmfToolDTO>? dtmf = null,

            global::System.Action<global::G.CreateEndCallToolDTO>? endCall = null,

            global::System.Action<global::G.CreateFunctionToolDTO>? function = null,

            global::System.Action<global::G.CreateTransferCallToolDTO>? transferCall = null,

            global::System.Action<global::G.CreateHandoffToolDTO>? handoff = null,

            global::System.Action<global::G.CreateBashToolDTO>? bash = null,

            global::System.Action<global::G.CreateComputerToolDTO>? computer = null,

            global::System.Action<global::G.CreateTextEditorToolDTO>? textEditor = null,

            global::System.Action<global::G.CreateQueryToolDTO>? query = null,

            global::System.Action<global::G.CreateGoogleCalendarCreateEventToolDTO>? googleCalendarEventCreate = null,

            global::System.Action<global::G.CreateGoogleSheetsRowAppendToolDTO>? googleSheetsRowAppend = null,

            global::System.Action<global::G.CreateGoogleCalendarCheckAvailabilityToolDTO>? googleCalendarAvailabilityCheck = null,

            global::System.Action<global::G.CreateSlackSendMessageToolDTO>? slackMessageSend = null,

            global::System.Action<global::G.CreateSmsToolDTO>? sms = null,

            global::System.Action<global::G.CreateMcpToolDTO>? mcp = null,

            global::System.Action<global::G.CreateGoHighLevelCalendarAvailabilityToolDTO>? gohighlevelCalendarAvailabilityCheck = null,

            global::System.Action<global::G.CreateGoHighLevelCalendarEventCreateToolDTO>? gohighlevelCalendarEventCreate = null,

            global::System.Action<global::G.CreateGoHighLevelContactCreateToolDTO>? gohighlevelContactCreate = null,

            global::System.Action<global::G.CreateGoHighLevelContactGetToolDTO>? gohighlevelContactGet = null,

            global::System.Action<global::G.CreateSipRequestToolDTO>? sipRequest = null,

            global::System.Action<global::G.CreateVoicemailToolDTO>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ApiRequest is { } __value0)
            {
                apiRequest?.Invoke(__value0);
            }
            else if (Code is { } __value1)
            {
                code?.Invoke(__value1);
            }
            else if (Dtmf is { } __value2)
            {
                dtmf?.Invoke(__value2);
            }
            else if (EndCall is { } __value3)
            {
                endCall?.Invoke(__value3);
            }
            else if (Function is { } __value4)
            {
                function?.Invoke(__value4);
            }
            else if (TransferCall is { } __value5)
            {
                transferCall?.Invoke(__value5);
            }
            else if (Handoff is { } __value6)
            {
                handoff?.Invoke(__value6);
            }
            else if (Bash is { } __value7)
            {
                bash?.Invoke(__value7);
            }
            else if (Computer is { } __value8)
            {
                computer?.Invoke(__value8);
            }
            else if (TextEditor is { } __value9)
            {
                textEditor?.Invoke(__value9);
            }
            else if (Query is { } __value10)
            {
                query?.Invoke(__value10);
            }
            else if (GoogleCalendarEventCreate is { } __value11)
            {
                googleCalendarEventCreate?.Invoke(__value11);
            }
            else if (GoogleSheetsRowAppend is { } __value12)
            {
                googleSheetsRowAppend?.Invoke(__value12);
            }
            else if (GoogleCalendarAvailabilityCheck is { } __value13)
            {
                googleCalendarAvailabilityCheck?.Invoke(__value13);
            }
            else if (SlackMessageSend is { } __value14)
            {
                slackMessageSend?.Invoke(__value14);
            }
            else if (Sms is { } __value15)
            {
                sms?.Invoke(__value15);
            }
            else if (Mcp is { } __value16)
            {
                mcp?.Invoke(__value16);
            }
            else if (GohighlevelCalendarAvailabilityCheck is { } __value17)
            {
                gohighlevelCalendarAvailabilityCheck?.Invoke(__value17);
            }
            else if (GohighlevelCalendarEventCreate is { } __value18)
            {
                gohighlevelCalendarEventCreate?.Invoke(__value18);
            }
            else if (GohighlevelContactCreate is { } __value19)
            {
                gohighlevelContactCreate?.Invoke(__value19);
            }
            else if (GohighlevelContactGet is { } __value20)
            {
                gohighlevelContactGet?.Invoke(__value20);
            }
            else if (SipRequest is { } __value21)
            {
                sipRequest?.Invoke(__value21);
            }
            else if (Voicemail is { } __value22)
            {
                voicemail?.Invoke(__value22);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.CreateApiRequestToolDTO>? apiRequest = null,
            global::System.Action<global::G.CreateCodeToolDTO>? code = null,
            global::System.Action<global::G.CreateDtmfToolDTO>? dtmf = null,
            global::System.Action<global::G.CreateEndCallToolDTO>? endCall = null,
            global::System.Action<global::G.CreateFunctionToolDTO>? function = null,
            global::System.Action<global::G.CreateTransferCallToolDTO>? transferCall = null,
            global::System.Action<global::G.CreateHandoffToolDTO>? handoff = null,
            global::System.Action<global::G.CreateBashToolDTO>? bash = null,
            global::System.Action<global::G.CreateComputerToolDTO>? computer = null,
            global::System.Action<global::G.CreateTextEditorToolDTO>? textEditor = null,
            global::System.Action<global::G.CreateQueryToolDTO>? query = null,
            global::System.Action<global::G.CreateGoogleCalendarCreateEventToolDTO>? googleCalendarEventCreate = null,
            global::System.Action<global::G.CreateGoogleSheetsRowAppendToolDTO>? googleSheetsRowAppend = null,
            global::System.Action<global::G.CreateGoogleCalendarCheckAvailabilityToolDTO>? googleCalendarAvailabilityCheck = null,
            global::System.Action<global::G.CreateSlackSendMessageToolDTO>? slackMessageSend = null,
            global::System.Action<global::G.CreateSmsToolDTO>? sms = null,
            global::System.Action<global::G.CreateMcpToolDTO>? mcp = null,
            global::System.Action<global::G.CreateGoHighLevelCalendarAvailabilityToolDTO>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Action<global::G.CreateGoHighLevelCalendarEventCreateToolDTO>? gohighlevelCalendarEventCreate = null,
            global::System.Action<global::G.CreateGoHighLevelContactCreateToolDTO>? gohighlevelContactCreate = null,
            global::System.Action<global::G.CreateGoHighLevelContactGetToolDTO>? gohighlevelContactGet = null,
            global::System.Action<global::G.CreateSipRequestToolDTO>? sipRequest = null,
            global::System.Action<global::G.CreateVoicemailToolDTO>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ApiRequest is { } __value0)
            {
                apiRequest?.Invoke(__value0);
            }
            else if (Code is { } __value1)
            {
                code?.Invoke(__value1);
            }
            else if (Dtmf is { } __value2)
            {
                dtmf?.Invoke(__value2);
            }
            else if (EndCall is { } __value3)
            {
                endCall?.Invoke(__value3);
            }
            else if (Function is { } __value4)
            {
                function?.Invoke(__value4);
            }
            else if (TransferCall is { } __value5)
            {
                transferCall?.Invoke(__value5);
            }
            else if (Handoff is { } __value6)
            {
                handoff?.Invoke(__value6);
            }
            else if (Bash is { } __value7)
            {
                bash?.Invoke(__value7);
            }
            else if (Computer is { } __value8)
            {
                computer?.Invoke(__value8);
            }
            else if (TextEditor is { } __value9)
            {
                textEditor?.Invoke(__value9);
            }
            else if (Query is { } __value10)
            {
                query?.Invoke(__value10);
            }
            else if (GoogleCalendarEventCreate is { } __value11)
            {
                googleCalendarEventCreate?.Invoke(__value11);
            }
            else if (GoogleSheetsRowAppend is { } __value12)
            {
                googleSheetsRowAppend?.Invoke(__value12);
            }
            else if (GoogleCalendarAvailabilityCheck is { } __value13)
            {
                googleCalendarAvailabilityCheck?.Invoke(__value13);
            }
            else if (SlackMessageSend is { } __value14)
            {
                slackMessageSend?.Invoke(__value14);
            }
            else if (Sms is { } __value15)
            {
                sms?.Invoke(__value15);
            }
            else if (Mcp is { } __value16)
            {
                mcp?.Invoke(__value16);
            }
            else if (GohighlevelCalendarAvailabilityCheck is { } __value17)
            {
                gohighlevelCalendarAvailabilityCheck?.Invoke(__value17);
            }
            else if (GohighlevelCalendarEventCreate is { } __value18)
            {
                gohighlevelCalendarEventCreate?.Invoke(__value18);
            }
            else if (GohighlevelContactCreate is { } __value19)
            {
                gohighlevelContactCreate?.Invoke(__value19);
            }
            else if (GohighlevelContactGet is { } __value20)
            {
                gohighlevelContactGet?.Invoke(__value20);
            }
            else if (SipRequest is { } __value21)
            {
                sipRequest?.Invoke(__value21);
            }
            else if (Voicemail is { } __value22)
            {
                voicemail?.Invoke(__value22);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiRequest,
                typeof(global::G.CreateApiRequestToolDTO),
                Code,
                typeof(global::G.CreateCodeToolDTO),
                Dtmf,
                typeof(global::G.CreateDtmfToolDTO),
                EndCall,
                typeof(global::G.CreateEndCallToolDTO),
                Function,
                typeof(global::G.CreateFunctionToolDTO),
                TransferCall,
                typeof(global::G.CreateTransferCallToolDTO),
                Handoff,
                typeof(global::G.CreateHandoffToolDTO),
                Bash,
                typeof(global::G.CreateBashToolDTO),
                Computer,
                typeof(global::G.CreateComputerToolDTO),
                TextEditor,
                typeof(global::G.CreateTextEditorToolDTO),
                Query,
                typeof(global::G.CreateQueryToolDTO),
                GoogleCalendarEventCreate,
                typeof(global::G.CreateGoogleCalendarCreateEventToolDTO),
                GoogleSheetsRowAppend,
                typeof(global::G.CreateGoogleSheetsRowAppendToolDTO),
                GoogleCalendarAvailabilityCheck,
                typeof(global::G.CreateGoogleCalendarCheckAvailabilityToolDTO),
                SlackMessageSend,
                typeof(global::G.CreateSlackSendMessageToolDTO),
                Sms,
                typeof(global::G.CreateSmsToolDTO),
                Mcp,
                typeof(global::G.CreateMcpToolDTO),
                GohighlevelCalendarAvailabilityCheck,
                typeof(global::G.CreateGoHighLevelCalendarAvailabilityToolDTO),
                GohighlevelCalendarEventCreate,
                typeof(global::G.CreateGoHighLevelCalendarEventCreateToolDTO),
                GohighlevelContactCreate,
                typeof(global::G.CreateGoHighLevelContactCreateToolDTO),
                GohighlevelContactGet,
                typeof(global::G.CreateGoHighLevelContactGetToolDTO),
                SipRequest,
                typeof(global::G.CreateSipRequestToolDTO),
                Voicemail,
                typeof(global::G.CreateVoicemailToolDTO),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ToolControllerCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateApiRequestToolDTO?>.Default.Equals(ApiRequest, other.ApiRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateCodeToolDTO?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateDtmfToolDTO?>.Default.Equals(Dtmf, other.Dtmf) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateEndCallToolDTO?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateFunctionToolDTO?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTransferCallToolDTO?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateHandoffToolDTO?>.Default.Equals(Handoff, other.Handoff) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateBashToolDTO?>.Default.Equals(Bash, other.Bash) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateComputerToolDTO?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTextEditorToolDTO?>.Default.Equals(TextEditor, other.TextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateQueryToolDTO?>.Default.Equals(Query, other.Query) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoogleCalendarCreateEventToolDTO?>.Default.Equals(GoogleCalendarEventCreate, other.GoogleCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoogleSheetsRowAppendToolDTO?>.Default.Equals(GoogleSheetsRowAppend, other.GoogleSheetsRowAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoogleCalendarCheckAvailabilityToolDTO?>.Default.Equals(GoogleCalendarAvailabilityCheck, other.GoogleCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSlackSendMessageToolDTO?>.Default.Equals(SlackMessageSend, other.SlackMessageSend) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSmsToolDTO?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateMcpToolDTO?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoHighLevelCalendarAvailabilityToolDTO?>.Default.Equals(GohighlevelCalendarAvailabilityCheck, other.GohighlevelCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoHighLevelCalendarEventCreateToolDTO?>.Default.Equals(GohighlevelCalendarEventCreate, other.GohighlevelCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoHighLevelContactCreateToolDTO?>.Default.Equals(GohighlevelContactCreate, other.GohighlevelContactCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateGoHighLevelContactGetToolDTO?>.Default.Equals(GohighlevelContactGet, other.GohighlevelContactGet) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSipRequestToolDTO?>.Default.Equals(SipRequest, other.SipRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateVoicemailToolDTO?>.Default.Equals(Voicemail, other.Voicemail) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolControllerCreateRequest obj1, ToolControllerCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolControllerCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolControllerCreateRequest obj1, ToolControllerCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolControllerCreateRequest o && Equals(o);
        }
    }
}
