//HintName: G.Models.ToolControllerUpdateRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolControllerUpdateRequest : global::System.IEquatable<ToolControllerUpdateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolControllerUpdateRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateApiRequestToolDTO? ApiRequest { get; init; }
#else
        public global::G.UpdateApiRequestToolDTO? ApiRequest { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateCodeToolDTO? Code { get; init; }
#else
        public global::G.UpdateCodeToolDTO? Code { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateDtmfToolDTO? Dtmf { get; init; }
#else
        public global::G.UpdateDtmfToolDTO? Dtmf { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateEndCallToolDTO? EndCall { get; init; }
#else
        public global::G.UpdateEndCallToolDTO? EndCall { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateFunctionToolDTO? Function { get; init; }
#else
        public global::G.UpdateFunctionToolDTO? Function { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateTransferCallToolDTO? TransferCall { get; init; }
#else
        public global::G.UpdateTransferCallToolDTO? TransferCall { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateHandoffToolDTO? Handoff { get; init; }
#else
        public global::G.UpdateHandoffToolDTO? Handoff { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateBashToolDTO? Bash { get; init; }
#else
        public global::G.UpdateBashToolDTO? Bash { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateComputerToolDTO? Computer { get; init; }
#else
        public global::G.UpdateComputerToolDTO? Computer { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateTextEditorToolDTO? TextEditor { get; init; }
#else
        public global::G.UpdateTextEditorToolDTO? TextEditor { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateQueryToolDTO? Query { get; init; }
#else
        public global::G.UpdateQueryToolDTO? Query { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateGoogleCalendarCreateEventToolDTO? GoogleCalendarEventCreate { get; init; }
#else
        public global::G.UpdateGoogleCalendarCreateEventToolDTO? GoogleCalendarEventCreate { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateGoogleSheetsRowAppendToolDTO? GoogleSheetsRowAppend { get; init; }
#else
        public global::G.UpdateGoogleSheetsRowAppendToolDTO? GoogleSheetsRowAppend { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO? GoogleCalendarAvailabilityCheck { get; init; }
#else
        public global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO? GoogleCalendarAvailabilityCheck { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateSlackSendMessageToolDTO? SlackMessageSend { get; init; }
#else
        public global::G.UpdateSlackSendMessageToolDTO? SlackMessageSend { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateSmsToolDTO? Sms { get; init; }
#else
        public global::G.UpdateSmsToolDTO? Sms { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateMcpToolDTO? Mcp { get; init; }
#else
        public global::G.UpdateMcpToolDTO? Mcp { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO? GohighlevelCalendarAvailabilityCheck { get; init; }
#else
        public global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO? GohighlevelCalendarAvailabilityCheck { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateGoHighLevelCalendarEventCreateToolDTO? GohighlevelCalendarEventCreate { get; init; }
#else
        public global::G.UpdateGoHighLevelCalendarEventCreateToolDTO? GohighlevelCalendarEventCreate { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateGoHighLevelContactCreateToolDTO? GohighlevelContactCreate { get; init; }
#else
        public global::G.UpdateGoHighLevelContactCreateToolDTO? GohighlevelContactCreate { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateGoHighLevelContactGetToolDTO? GohighlevelContactGet { get; init; }
#else
        public global::G.UpdateGoHighLevelContactGetToolDTO? GohighlevelContactGet { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateSipRequestToolDTO? SipRequest { get; init; }
#else
        public global::G.UpdateSipRequestToolDTO? SipRequest { get; }
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
#if NET6_0_OR_GREATER
        public global::G.UpdateVoicemailToolDTO? Voicemail { get; init; }
#else
        public global::G.UpdateVoicemailToolDTO? Voicemail { get; }
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
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateApiRequestToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateApiRequestToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateApiRequestToolDTO?(ToolControllerUpdateRequest @this) => @this.ApiRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateApiRequestToolDTO? value)
        {
            ApiRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateCodeToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateCodeToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateCodeToolDTO?(ToolControllerUpdateRequest @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateCodeToolDTO? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateDtmfToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateDtmfToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateDtmfToolDTO?(ToolControllerUpdateRequest @this) => @this.Dtmf;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateDtmfToolDTO? value)
        {
            Dtmf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateEndCallToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateEndCallToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateEndCallToolDTO?(ToolControllerUpdateRequest @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateEndCallToolDTO? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateFunctionToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateFunctionToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateFunctionToolDTO?(ToolControllerUpdateRequest @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateFunctionToolDTO? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateTransferCallToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateTransferCallToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateTransferCallToolDTO?(ToolControllerUpdateRequest @this) => @this.TransferCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateTransferCallToolDTO? value)
        {
            TransferCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateHandoffToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateHandoffToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateHandoffToolDTO?(ToolControllerUpdateRequest @this) => @this.Handoff;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateHandoffToolDTO? value)
        {
            Handoff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateBashToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateBashToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateBashToolDTO?(ToolControllerUpdateRequest @this) => @this.Bash;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateBashToolDTO? value)
        {
            Bash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateComputerToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateComputerToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateComputerToolDTO?(ToolControllerUpdateRequest @this) => @this.Computer;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateComputerToolDTO? value)
        {
            Computer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateTextEditorToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateTextEditorToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateTextEditorToolDTO?(ToolControllerUpdateRequest @this) => @this.TextEditor;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateTextEditorToolDTO? value)
        {
            TextEditor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateQueryToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateQueryToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateQueryToolDTO?(ToolControllerUpdateRequest @this) => @this.Query;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateQueryToolDTO? value)
        {
            Query = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateGoogleCalendarCreateEventToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateGoogleCalendarCreateEventToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateGoogleCalendarCreateEventToolDTO?(ToolControllerUpdateRequest @this) => @this.GoogleCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateGoogleCalendarCreateEventToolDTO? value)
        {
            GoogleCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateGoogleSheetsRowAppendToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateGoogleSheetsRowAppendToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateGoogleSheetsRowAppendToolDTO?(ToolControllerUpdateRequest @this) => @this.GoogleSheetsRowAppend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateGoogleSheetsRowAppendToolDTO? value)
        {
            GoogleSheetsRowAppend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO?(ToolControllerUpdateRequest @this) => @this.GoogleCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO? value)
        {
            GoogleCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateSlackSendMessageToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateSlackSendMessageToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateSlackSendMessageToolDTO?(ToolControllerUpdateRequest @this) => @this.SlackMessageSend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateSlackSendMessageToolDTO? value)
        {
            SlackMessageSend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateSmsToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateSmsToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateSmsToolDTO?(ToolControllerUpdateRequest @this) => @this.Sms;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateSmsToolDTO? value)
        {
            Sms = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateMcpToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateMcpToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateMcpToolDTO?(ToolControllerUpdateRequest @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateMcpToolDTO? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO?(ToolControllerUpdateRequest @this) => @this.GohighlevelCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO? value)
        {
            GohighlevelCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateGoHighLevelCalendarEventCreateToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateGoHighLevelCalendarEventCreateToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateGoHighLevelCalendarEventCreateToolDTO?(ToolControllerUpdateRequest @this) => @this.GohighlevelCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateGoHighLevelCalendarEventCreateToolDTO? value)
        {
            GohighlevelCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateGoHighLevelContactCreateToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateGoHighLevelContactCreateToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateGoHighLevelContactCreateToolDTO?(ToolControllerUpdateRequest @this) => @this.GohighlevelContactCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateGoHighLevelContactCreateToolDTO? value)
        {
            GohighlevelContactCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateGoHighLevelContactGetToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateGoHighLevelContactGetToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateGoHighLevelContactGetToolDTO?(ToolControllerUpdateRequest @this) => @this.GohighlevelContactGet;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateGoHighLevelContactGetToolDTO? value)
        {
            GohighlevelContactGet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateSipRequestToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateSipRequestToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateSipRequestToolDTO?(ToolControllerUpdateRequest @this) => @this.SipRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateSipRequestToolDTO? value)
        {
            SipRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::G.UpdateVoicemailToolDTO value) => new ToolControllerUpdateRequest((global::G.UpdateVoicemailToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateVoicemailToolDTO?(ToolControllerUpdateRequest @this) => @this.Voicemail;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(global::G.UpdateVoicemailToolDTO? value)
        {
            Voicemail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateRequest(
            global::G.ToolControllerUpdateRequestDiscriminatorType? type,
            global::G.UpdateApiRequestToolDTO? apiRequest,
            global::G.UpdateCodeToolDTO? code,
            global::G.UpdateDtmfToolDTO? dtmf,
            global::G.UpdateEndCallToolDTO? endCall,
            global::G.UpdateFunctionToolDTO? function,
            global::G.UpdateTransferCallToolDTO? transferCall,
            global::G.UpdateHandoffToolDTO? handoff,
            global::G.UpdateBashToolDTO? bash,
            global::G.UpdateComputerToolDTO? computer,
            global::G.UpdateTextEditorToolDTO? textEditor,
            global::G.UpdateQueryToolDTO? query,
            global::G.UpdateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate,
            global::G.UpdateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend,
            global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck,
            global::G.UpdateSlackSendMessageToolDTO? slackMessageSend,
            global::G.UpdateSmsToolDTO? sms,
            global::G.UpdateMcpToolDTO? mcp,
            global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck,
            global::G.UpdateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate,
            global::G.UpdateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate,
            global::G.UpdateGoHighLevelContactGetToolDTO? gohighlevelContactGet,
            global::G.UpdateSipRequestToolDTO? sipRequest,
            global::G.UpdateVoicemailToolDTO? voicemail
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
            global::System.Func<global::G.UpdateApiRequestToolDTO?, TResult>? apiRequest = null,
            global::System.Func<global::G.UpdateCodeToolDTO?, TResult>? code = null,
            global::System.Func<global::G.UpdateDtmfToolDTO?, TResult>? dtmf = null,
            global::System.Func<global::G.UpdateEndCallToolDTO?, TResult>? endCall = null,
            global::System.Func<global::G.UpdateFunctionToolDTO?, TResult>? function = null,
            global::System.Func<global::G.UpdateTransferCallToolDTO?, TResult>? transferCall = null,
            global::System.Func<global::G.UpdateHandoffToolDTO?, TResult>? handoff = null,
            global::System.Func<global::G.UpdateBashToolDTO?, TResult>? bash = null,
            global::System.Func<global::G.UpdateComputerToolDTO?, TResult>? computer = null,
            global::System.Func<global::G.UpdateTextEditorToolDTO?, TResult>? textEditor = null,
            global::System.Func<global::G.UpdateQueryToolDTO?, TResult>? query = null,
            global::System.Func<global::G.UpdateGoogleCalendarCreateEventToolDTO?, TResult>? googleCalendarEventCreate = null,
            global::System.Func<global::G.UpdateGoogleSheetsRowAppendToolDTO?, TResult>? googleSheetsRowAppend = null,
            global::System.Func<global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO?, TResult>? googleCalendarAvailabilityCheck = null,
            global::System.Func<global::G.UpdateSlackSendMessageToolDTO?, TResult>? slackMessageSend = null,
            global::System.Func<global::G.UpdateSmsToolDTO?, TResult>? sms = null,
            global::System.Func<global::G.UpdateMcpToolDTO?, TResult>? mcp = null,
            global::System.Func<global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO?, TResult>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Func<global::G.UpdateGoHighLevelCalendarEventCreateToolDTO?, TResult>? gohighlevelCalendarEventCreate = null,
            global::System.Func<global::G.UpdateGoHighLevelContactCreateToolDTO?, TResult>? gohighlevelContactCreate = null,
            global::System.Func<global::G.UpdateGoHighLevelContactGetToolDTO?, TResult>? gohighlevelContactGet = null,
            global::System.Func<global::G.UpdateSipRequestToolDTO?, TResult>? sipRequest = null,
            global::System.Func<global::G.UpdateVoicemailToolDTO?, TResult>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiRequest && apiRequest != null)
            {
                return apiRequest(ApiRequest!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsDtmf && dtmf != null)
            {
                return dtmf(Dtmf!);
            }
            else if (IsEndCall && endCall != null)
            {
                return endCall(EndCall!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsTransferCall && transferCall != null)
            {
                return transferCall(TransferCall!);
            }
            else if (IsHandoff && handoff != null)
            {
                return handoff(Handoff!);
            }
            else if (IsBash && bash != null)
            {
                return bash(Bash!);
            }
            else if (IsComputer && computer != null)
            {
                return computer(Computer!);
            }
            else if (IsTextEditor && textEditor != null)
            {
                return textEditor(TextEditor!);
            }
            else if (IsQuery && query != null)
            {
                return query(Query!);
            }
            else if (IsGoogleCalendarEventCreate && googleCalendarEventCreate != null)
            {
                return googleCalendarEventCreate(GoogleCalendarEventCreate!);
            }
            else if (IsGoogleSheetsRowAppend && googleSheetsRowAppend != null)
            {
                return googleSheetsRowAppend(GoogleSheetsRowAppend!);
            }
            else if (IsGoogleCalendarAvailabilityCheck && googleCalendarAvailabilityCheck != null)
            {
                return googleCalendarAvailabilityCheck(GoogleCalendarAvailabilityCheck!);
            }
            else if (IsSlackMessageSend && slackMessageSend != null)
            {
                return slackMessageSend(SlackMessageSend!);
            }
            else if (IsSms && sms != null)
            {
                return sms(Sms!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsGohighlevelCalendarAvailabilityCheck && gohighlevelCalendarAvailabilityCheck != null)
            {
                return gohighlevelCalendarAvailabilityCheck(GohighlevelCalendarAvailabilityCheck!);
            }
            else if (IsGohighlevelCalendarEventCreate && gohighlevelCalendarEventCreate != null)
            {
                return gohighlevelCalendarEventCreate(GohighlevelCalendarEventCreate!);
            }
            else if (IsGohighlevelContactCreate && gohighlevelContactCreate != null)
            {
                return gohighlevelContactCreate(GohighlevelContactCreate!);
            }
            else if (IsGohighlevelContactGet && gohighlevelContactGet != null)
            {
                return gohighlevelContactGet(GohighlevelContactGet!);
            }
            else if (IsSipRequest && sipRequest != null)
            {
                return sipRequest(SipRequest!);
            }
            else if (IsVoicemail && voicemail != null)
            {
                return voicemail(Voicemail!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.UpdateApiRequestToolDTO?>? apiRequest = null,
            global::System.Action<global::G.UpdateCodeToolDTO?>? code = null,
            global::System.Action<global::G.UpdateDtmfToolDTO?>? dtmf = null,
            global::System.Action<global::G.UpdateEndCallToolDTO?>? endCall = null,
            global::System.Action<global::G.UpdateFunctionToolDTO?>? function = null,
            global::System.Action<global::G.UpdateTransferCallToolDTO?>? transferCall = null,
            global::System.Action<global::G.UpdateHandoffToolDTO?>? handoff = null,
            global::System.Action<global::G.UpdateBashToolDTO?>? bash = null,
            global::System.Action<global::G.UpdateComputerToolDTO?>? computer = null,
            global::System.Action<global::G.UpdateTextEditorToolDTO?>? textEditor = null,
            global::System.Action<global::G.UpdateQueryToolDTO?>? query = null,
            global::System.Action<global::G.UpdateGoogleCalendarCreateEventToolDTO?>? googleCalendarEventCreate = null,
            global::System.Action<global::G.UpdateGoogleSheetsRowAppendToolDTO?>? googleSheetsRowAppend = null,
            global::System.Action<global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO?>? googleCalendarAvailabilityCheck = null,
            global::System.Action<global::G.UpdateSlackSendMessageToolDTO?>? slackMessageSend = null,
            global::System.Action<global::G.UpdateSmsToolDTO?>? sms = null,
            global::System.Action<global::G.UpdateMcpToolDTO?>? mcp = null,
            global::System.Action<global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO?>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Action<global::G.UpdateGoHighLevelCalendarEventCreateToolDTO?>? gohighlevelCalendarEventCreate = null,
            global::System.Action<global::G.UpdateGoHighLevelContactCreateToolDTO?>? gohighlevelContactCreate = null,
            global::System.Action<global::G.UpdateGoHighLevelContactGetToolDTO?>? gohighlevelContactGet = null,
            global::System.Action<global::G.UpdateSipRequestToolDTO?>? sipRequest = null,
            global::System.Action<global::G.UpdateVoicemailToolDTO?>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiRequest)
            {
                apiRequest?.Invoke(ApiRequest!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsDtmf)
            {
                dtmf?.Invoke(Dtmf!);
            }
            else if (IsEndCall)
            {
                endCall?.Invoke(EndCall!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsTransferCall)
            {
                transferCall?.Invoke(TransferCall!);
            }
            else if (IsHandoff)
            {
                handoff?.Invoke(Handoff!);
            }
            else if (IsBash)
            {
                bash?.Invoke(Bash!);
            }
            else if (IsComputer)
            {
                computer?.Invoke(Computer!);
            }
            else if (IsTextEditor)
            {
                textEditor?.Invoke(TextEditor!);
            }
            else if (IsQuery)
            {
                query?.Invoke(Query!);
            }
            else if (IsGoogleCalendarEventCreate)
            {
                googleCalendarEventCreate?.Invoke(GoogleCalendarEventCreate!);
            }
            else if (IsGoogleSheetsRowAppend)
            {
                googleSheetsRowAppend?.Invoke(GoogleSheetsRowAppend!);
            }
            else if (IsGoogleCalendarAvailabilityCheck)
            {
                googleCalendarAvailabilityCheck?.Invoke(GoogleCalendarAvailabilityCheck!);
            }
            else if (IsSlackMessageSend)
            {
                slackMessageSend?.Invoke(SlackMessageSend!);
            }
            else if (IsSms)
            {
                sms?.Invoke(Sms!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsGohighlevelCalendarAvailabilityCheck)
            {
                gohighlevelCalendarAvailabilityCheck?.Invoke(GohighlevelCalendarAvailabilityCheck!);
            }
            else if (IsGohighlevelCalendarEventCreate)
            {
                gohighlevelCalendarEventCreate?.Invoke(GohighlevelCalendarEventCreate!);
            }
            else if (IsGohighlevelContactCreate)
            {
                gohighlevelContactCreate?.Invoke(GohighlevelContactCreate!);
            }
            else if (IsGohighlevelContactGet)
            {
                gohighlevelContactGet?.Invoke(GohighlevelContactGet!);
            }
            else if (IsSipRequest)
            {
                sipRequest?.Invoke(SipRequest!);
            }
            else if (IsVoicemail)
            {
                voicemail?.Invoke(Voicemail!);
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
                typeof(global::G.UpdateApiRequestToolDTO),
                Code,
                typeof(global::G.UpdateCodeToolDTO),
                Dtmf,
                typeof(global::G.UpdateDtmfToolDTO),
                EndCall,
                typeof(global::G.UpdateEndCallToolDTO),
                Function,
                typeof(global::G.UpdateFunctionToolDTO),
                TransferCall,
                typeof(global::G.UpdateTransferCallToolDTO),
                Handoff,
                typeof(global::G.UpdateHandoffToolDTO),
                Bash,
                typeof(global::G.UpdateBashToolDTO),
                Computer,
                typeof(global::G.UpdateComputerToolDTO),
                TextEditor,
                typeof(global::G.UpdateTextEditorToolDTO),
                Query,
                typeof(global::G.UpdateQueryToolDTO),
                GoogleCalendarEventCreate,
                typeof(global::G.UpdateGoogleCalendarCreateEventToolDTO),
                GoogleSheetsRowAppend,
                typeof(global::G.UpdateGoogleSheetsRowAppendToolDTO),
                GoogleCalendarAvailabilityCheck,
                typeof(global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO),
                SlackMessageSend,
                typeof(global::G.UpdateSlackSendMessageToolDTO),
                Sms,
                typeof(global::G.UpdateSmsToolDTO),
                Mcp,
                typeof(global::G.UpdateMcpToolDTO),
                GohighlevelCalendarAvailabilityCheck,
                typeof(global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO),
                GohighlevelCalendarEventCreate,
                typeof(global::G.UpdateGoHighLevelCalendarEventCreateToolDTO),
                GohighlevelContactCreate,
                typeof(global::G.UpdateGoHighLevelContactCreateToolDTO),
                GohighlevelContactGet,
                typeof(global::G.UpdateGoHighLevelContactGetToolDTO),
                SipRequest,
                typeof(global::G.UpdateSipRequestToolDTO),
                Voicemail,
                typeof(global::G.UpdateVoicemailToolDTO),
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
        public bool Equals(ToolControllerUpdateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateApiRequestToolDTO?>.Default.Equals(ApiRequest, other.ApiRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateCodeToolDTO?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateDtmfToolDTO?>.Default.Equals(Dtmf, other.Dtmf) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateEndCallToolDTO?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateFunctionToolDTO?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateTransferCallToolDTO?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateHandoffToolDTO?>.Default.Equals(Handoff, other.Handoff) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateBashToolDTO?>.Default.Equals(Bash, other.Bash) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateComputerToolDTO?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateTextEditorToolDTO?>.Default.Equals(TextEditor, other.TextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateQueryToolDTO?>.Default.Equals(Query, other.Query) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateGoogleCalendarCreateEventToolDTO?>.Default.Equals(GoogleCalendarEventCreate, other.GoogleCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateGoogleSheetsRowAppendToolDTO?>.Default.Equals(GoogleSheetsRowAppend, other.GoogleSheetsRowAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateGoogleCalendarCheckAvailabilityToolDTO?>.Default.Equals(GoogleCalendarAvailabilityCheck, other.GoogleCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateSlackSendMessageToolDTO?>.Default.Equals(SlackMessageSend, other.SlackMessageSend) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateSmsToolDTO?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateMcpToolDTO?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateGoHighLevelCalendarAvailabilityToolDTO?>.Default.Equals(GohighlevelCalendarAvailabilityCheck, other.GohighlevelCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateGoHighLevelCalendarEventCreateToolDTO?>.Default.Equals(GohighlevelCalendarEventCreate, other.GohighlevelCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateGoHighLevelContactCreateToolDTO?>.Default.Equals(GohighlevelContactCreate, other.GohighlevelContactCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateGoHighLevelContactGetToolDTO?>.Default.Equals(GohighlevelContactGet, other.GohighlevelContactGet) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateSipRequestToolDTO?>.Default.Equals(SipRequest, other.SipRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateVoicemailToolDTO?>.Default.Equals(Voicemail, other.Voicemail) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolControllerUpdateRequest obj1, ToolControllerUpdateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolControllerUpdateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolControllerUpdateRequest obj1, ToolControllerUpdateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolControllerUpdateRequest o && Equals(o);
        }
    }
}
