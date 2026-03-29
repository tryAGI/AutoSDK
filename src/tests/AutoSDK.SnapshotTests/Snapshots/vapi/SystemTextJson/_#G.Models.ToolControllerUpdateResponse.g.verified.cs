//HintName: G.Models.ToolControllerUpdateResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolControllerUpdateResponse : global::System.IEquatable<ToolControllerUpdateResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolControllerUpdateResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ApiRequestTool? ApiRequest { get; init; }
#else
        public global::G.ApiRequestTool? ApiRequest { get; }
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
        public global::G.CodeTool? Code { get; init; }
#else
        public global::G.CodeTool? Code { get; }
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
        public global::G.DtmfTool? Dtmf { get; init; }
#else
        public global::G.DtmfTool? Dtmf { get; }
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
        public global::G.EndCallTool? EndCall { get; init; }
#else
        public global::G.EndCallTool? EndCall { get; }
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
        public global::G.FunctionTool? Function { get; init; }
#else
        public global::G.FunctionTool? Function { get; }
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
        public global::G.GhlTool? Ghl { get; init; }
#else
        public global::G.GhlTool? Ghl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ghl))]
#endif
        public bool IsGhl => Ghl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TransferCallTool? TransferCall { get; init; }
#else
        public global::G.TransferCallTool? TransferCall { get; }
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
        public global::G.HandoffTool? Handoff { get; init; }
#else
        public global::G.HandoffTool? Handoff { get; }
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
        public global::G.BashTool? Bash { get; init; }
#else
        public global::G.BashTool? Bash { get; }
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
        public global::G.ComputerTool? Computer { get; init; }
#else
        public global::G.ComputerTool? Computer { get; }
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
        public global::G.TextEditorTool? TextEditor { get; init; }
#else
        public global::G.TextEditorTool? TextEditor { get; }
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
        public global::G.QueryTool? Query { get; init; }
#else
        public global::G.QueryTool? Query { get; }
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
        public global::G.GoogleCalendarCreateEventTool? GoogleCalendarEventCreate { get; init; }
#else
        public global::G.GoogleCalendarCreateEventTool? GoogleCalendarEventCreate { get; }
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
        public global::G.GoogleSheetsRowAppendTool? GoogleSheetsRowAppend { get; init; }
#else
        public global::G.GoogleSheetsRowAppendTool? GoogleSheetsRowAppend { get; }
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
        public global::G.GoogleCalendarCheckAvailabilityTool? GoogleCalendarAvailabilityCheck { get; init; }
#else
        public global::G.GoogleCalendarCheckAvailabilityTool? GoogleCalendarAvailabilityCheck { get; }
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
        public global::G.SlackSendMessageTool? SlackMessageSend { get; init; }
#else
        public global::G.SlackSendMessageTool? SlackMessageSend { get; }
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
        public global::G.SmsTool? Sms { get; init; }
#else
        public global::G.SmsTool? Sms { get; }
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
        public global::G.McpTool? Mcp { get; init; }
#else
        public global::G.McpTool? Mcp { get; }
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
        public global::G.GoHighLevelCalendarAvailabilityTool? GohighlevelCalendarAvailabilityCheck { get; init; }
#else
        public global::G.GoHighLevelCalendarAvailabilityTool? GohighlevelCalendarAvailabilityCheck { get; }
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
        public global::G.GoHighLevelCalendarEventCreateTool? GohighlevelCalendarEventCreate { get; init; }
#else
        public global::G.GoHighLevelCalendarEventCreateTool? GohighlevelCalendarEventCreate { get; }
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
        public global::G.GoHighLevelContactCreateTool? GohighlevelContactCreate { get; init; }
#else
        public global::G.GoHighLevelContactCreateTool? GohighlevelContactCreate { get; }
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
        public global::G.GoHighLevelContactGetTool? GohighlevelContactGet { get; init; }
#else
        public global::G.GoHighLevelContactGetTool? GohighlevelContactGet { get; }
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
        public global::G.SipRequestTool? SipRequest { get; init; }
#else
        public global::G.SipRequestTool? SipRequest { get; }
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
        public global::G.VoicemailTool? Voicemail { get; init; }
#else
        public global::G.VoicemailTool? Voicemail { get; }
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
        public static implicit operator ToolControllerUpdateResponse(global::G.ApiRequestTool value) => new ToolControllerUpdateResponse((global::G.ApiRequestTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ApiRequestTool?(ToolControllerUpdateResponse @this) => @this.ApiRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.ApiRequestTool? value)
        {
            ApiRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.CodeTool value) => new ToolControllerUpdateResponse((global::G.CodeTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeTool?(ToolControllerUpdateResponse @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.CodeTool? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.DtmfTool value) => new ToolControllerUpdateResponse((global::G.DtmfTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DtmfTool?(ToolControllerUpdateResponse @this) => @this.Dtmf;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.DtmfTool? value)
        {
            Dtmf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.EndCallTool value) => new ToolControllerUpdateResponse((global::G.EndCallTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EndCallTool?(ToolControllerUpdateResponse @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.EndCallTool? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.FunctionTool value) => new ToolControllerUpdateResponse((global::G.FunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionTool?(ToolControllerUpdateResponse @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.FunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.GhlTool value) => new ToolControllerUpdateResponse((global::G.GhlTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GhlTool?(ToolControllerUpdateResponse @this) => @this.Ghl;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.GhlTool? value)
        {
            Ghl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.TransferCallTool value) => new ToolControllerUpdateResponse((global::G.TransferCallTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferCallTool?(ToolControllerUpdateResponse @this) => @this.TransferCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.TransferCallTool? value)
        {
            TransferCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.HandoffTool value) => new ToolControllerUpdateResponse((global::G.HandoffTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HandoffTool?(ToolControllerUpdateResponse @this) => @this.Handoff;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.HandoffTool? value)
        {
            Handoff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.BashTool value) => new ToolControllerUpdateResponse((global::G.BashTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BashTool?(ToolControllerUpdateResponse @this) => @this.Bash;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.BashTool? value)
        {
            Bash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.ComputerTool value) => new ToolControllerUpdateResponse((global::G.ComputerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerTool?(ToolControllerUpdateResponse @this) => @this.Computer;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.ComputerTool? value)
        {
            Computer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.TextEditorTool value) => new ToolControllerUpdateResponse((global::G.TextEditorTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextEditorTool?(ToolControllerUpdateResponse @this) => @this.TextEditor;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.TextEditorTool? value)
        {
            TextEditor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.QueryTool value) => new ToolControllerUpdateResponse((global::G.QueryTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.QueryTool?(ToolControllerUpdateResponse @this) => @this.Query;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.QueryTool? value)
        {
            Query = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.GoogleCalendarCreateEventTool value) => new ToolControllerUpdateResponse((global::G.GoogleCalendarCreateEventTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GoogleCalendarCreateEventTool?(ToolControllerUpdateResponse @this) => @this.GoogleCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.GoogleCalendarCreateEventTool? value)
        {
            GoogleCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.GoogleSheetsRowAppendTool value) => new ToolControllerUpdateResponse((global::G.GoogleSheetsRowAppendTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GoogleSheetsRowAppendTool?(ToolControllerUpdateResponse @this) => @this.GoogleSheetsRowAppend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.GoogleSheetsRowAppendTool? value)
        {
            GoogleSheetsRowAppend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.GoogleCalendarCheckAvailabilityTool value) => new ToolControllerUpdateResponse((global::G.GoogleCalendarCheckAvailabilityTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GoogleCalendarCheckAvailabilityTool?(ToolControllerUpdateResponse @this) => @this.GoogleCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.GoogleCalendarCheckAvailabilityTool? value)
        {
            GoogleCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.SlackSendMessageTool value) => new ToolControllerUpdateResponse((global::G.SlackSendMessageTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SlackSendMessageTool?(ToolControllerUpdateResponse @this) => @this.SlackMessageSend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.SlackSendMessageTool? value)
        {
            SlackMessageSend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.SmsTool value) => new ToolControllerUpdateResponse((global::G.SmsTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsTool?(ToolControllerUpdateResponse @this) => @this.Sms;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.SmsTool? value)
        {
            Sms = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.McpTool value) => new ToolControllerUpdateResponse((global::G.McpTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.McpTool?(ToolControllerUpdateResponse @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.McpTool? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.GoHighLevelCalendarAvailabilityTool value) => new ToolControllerUpdateResponse((global::G.GoHighLevelCalendarAvailabilityTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GoHighLevelCalendarAvailabilityTool?(ToolControllerUpdateResponse @this) => @this.GohighlevelCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.GoHighLevelCalendarAvailabilityTool? value)
        {
            GohighlevelCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.GoHighLevelCalendarEventCreateTool value) => new ToolControllerUpdateResponse((global::G.GoHighLevelCalendarEventCreateTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GoHighLevelCalendarEventCreateTool?(ToolControllerUpdateResponse @this) => @this.GohighlevelCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.GoHighLevelCalendarEventCreateTool? value)
        {
            GohighlevelCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.GoHighLevelContactCreateTool value) => new ToolControllerUpdateResponse((global::G.GoHighLevelContactCreateTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GoHighLevelContactCreateTool?(ToolControllerUpdateResponse @this) => @this.GohighlevelContactCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.GoHighLevelContactCreateTool? value)
        {
            GohighlevelContactCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.GoHighLevelContactGetTool value) => new ToolControllerUpdateResponse((global::G.GoHighLevelContactGetTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GoHighLevelContactGetTool?(ToolControllerUpdateResponse @this) => @this.GohighlevelContactGet;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.GoHighLevelContactGetTool? value)
        {
            GohighlevelContactGet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.SipRequestTool value) => new ToolControllerUpdateResponse((global::G.SipRequestTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SipRequestTool?(ToolControllerUpdateResponse @this) => @this.SipRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.SipRequestTool? value)
        {
            SipRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerUpdateResponse(global::G.VoicemailTool value) => new ToolControllerUpdateResponse((global::G.VoicemailTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VoicemailTool?(ToolControllerUpdateResponse @this) => @this.Voicemail;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(global::G.VoicemailTool? value)
        {
            Voicemail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerUpdateResponse(
            global::G.ToolControllerUpdateResponseDiscriminatorType? type,
            global::G.ApiRequestTool? apiRequest,
            global::G.CodeTool? code,
            global::G.DtmfTool? dtmf,
            global::G.EndCallTool? endCall,
            global::G.FunctionTool? function,
            global::G.GhlTool? ghl,
            global::G.TransferCallTool? transferCall,
            global::G.HandoffTool? handoff,
            global::G.BashTool? bash,
            global::G.ComputerTool? computer,
            global::G.TextEditorTool? textEditor,
            global::G.QueryTool? query,
            global::G.GoogleCalendarCreateEventTool? googleCalendarEventCreate,
            global::G.GoogleSheetsRowAppendTool? googleSheetsRowAppend,
            global::G.GoogleCalendarCheckAvailabilityTool? googleCalendarAvailabilityCheck,
            global::G.SlackSendMessageTool? slackMessageSend,
            global::G.SmsTool? sms,
            global::G.McpTool? mcp,
            global::G.GoHighLevelCalendarAvailabilityTool? gohighlevelCalendarAvailabilityCheck,
            global::G.GoHighLevelCalendarEventCreateTool? gohighlevelCalendarEventCreate,
            global::G.GoHighLevelContactCreateTool? gohighlevelContactCreate,
            global::G.GoHighLevelContactGetTool? gohighlevelContactGet,
            global::G.SipRequestTool? sipRequest,
            global::G.VoicemailTool? voicemail
            )
        {
            Type = type;

            ApiRequest = apiRequest;
            Code = code;
            Dtmf = dtmf;
            EndCall = endCall;
            Function = function;
            Ghl = ghl;
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
            Ghl as object ??
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
            Ghl?.ToString() ??
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
            return IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && IsVoicemail;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ApiRequestTool?, TResult>? apiRequest = null,
            global::System.Func<global::G.CodeTool?, TResult>? code = null,
            global::System.Func<global::G.DtmfTool?, TResult>? dtmf = null,
            global::System.Func<global::G.EndCallTool?, TResult>? endCall = null,
            global::System.Func<global::G.FunctionTool?, TResult>? function = null,
            global::System.Func<global::G.GhlTool?, TResult>? ghl = null,
            global::System.Func<global::G.TransferCallTool?, TResult>? transferCall = null,
            global::System.Func<global::G.HandoffTool?, TResult>? handoff = null,
            global::System.Func<global::G.BashTool?, TResult>? bash = null,
            global::System.Func<global::G.ComputerTool?, TResult>? computer = null,
            global::System.Func<global::G.TextEditorTool?, TResult>? textEditor = null,
            global::System.Func<global::G.QueryTool?, TResult>? query = null,
            global::System.Func<global::G.GoogleCalendarCreateEventTool?, TResult>? googleCalendarEventCreate = null,
            global::System.Func<global::G.GoogleSheetsRowAppendTool?, TResult>? googleSheetsRowAppend = null,
            global::System.Func<global::G.GoogleCalendarCheckAvailabilityTool?, TResult>? googleCalendarAvailabilityCheck = null,
            global::System.Func<global::G.SlackSendMessageTool?, TResult>? slackMessageSend = null,
            global::System.Func<global::G.SmsTool?, TResult>? sms = null,
            global::System.Func<global::G.McpTool?, TResult>? mcp = null,
            global::System.Func<global::G.GoHighLevelCalendarAvailabilityTool?, TResult>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Func<global::G.GoHighLevelCalendarEventCreateTool?, TResult>? gohighlevelCalendarEventCreate = null,
            global::System.Func<global::G.GoHighLevelContactCreateTool?, TResult>? gohighlevelContactCreate = null,
            global::System.Func<global::G.GoHighLevelContactGetTool?, TResult>? gohighlevelContactGet = null,
            global::System.Func<global::G.SipRequestTool?, TResult>? sipRequest = null,
            global::System.Func<global::G.VoicemailTool?, TResult>? voicemail = null,
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
            else if (IsGhl && ghl != null)
            {
                return ghl(Ghl!);
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
            global::System.Action<global::G.ApiRequestTool?>? apiRequest = null,
            global::System.Action<global::G.CodeTool?>? code = null,
            global::System.Action<global::G.DtmfTool?>? dtmf = null,
            global::System.Action<global::G.EndCallTool?>? endCall = null,
            global::System.Action<global::G.FunctionTool?>? function = null,
            global::System.Action<global::G.GhlTool?>? ghl = null,
            global::System.Action<global::G.TransferCallTool?>? transferCall = null,
            global::System.Action<global::G.HandoffTool?>? handoff = null,
            global::System.Action<global::G.BashTool?>? bash = null,
            global::System.Action<global::G.ComputerTool?>? computer = null,
            global::System.Action<global::G.TextEditorTool?>? textEditor = null,
            global::System.Action<global::G.QueryTool?>? query = null,
            global::System.Action<global::G.GoogleCalendarCreateEventTool?>? googleCalendarEventCreate = null,
            global::System.Action<global::G.GoogleSheetsRowAppendTool?>? googleSheetsRowAppend = null,
            global::System.Action<global::G.GoogleCalendarCheckAvailabilityTool?>? googleCalendarAvailabilityCheck = null,
            global::System.Action<global::G.SlackSendMessageTool?>? slackMessageSend = null,
            global::System.Action<global::G.SmsTool?>? sms = null,
            global::System.Action<global::G.McpTool?>? mcp = null,
            global::System.Action<global::G.GoHighLevelCalendarAvailabilityTool?>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Action<global::G.GoHighLevelCalendarEventCreateTool?>? gohighlevelCalendarEventCreate = null,
            global::System.Action<global::G.GoHighLevelContactCreateTool?>? gohighlevelContactCreate = null,
            global::System.Action<global::G.GoHighLevelContactGetTool?>? gohighlevelContactGet = null,
            global::System.Action<global::G.SipRequestTool?>? sipRequest = null,
            global::System.Action<global::G.VoicemailTool?>? voicemail = null,
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
            else if (IsGhl)
            {
                ghl?.Invoke(Ghl!);
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
                typeof(global::G.ApiRequestTool),
                Code,
                typeof(global::G.CodeTool),
                Dtmf,
                typeof(global::G.DtmfTool),
                EndCall,
                typeof(global::G.EndCallTool),
                Function,
                typeof(global::G.FunctionTool),
                Ghl,
                typeof(global::G.GhlTool),
                TransferCall,
                typeof(global::G.TransferCallTool),
                Handoff,
                typeof(global::G.HandoffTool),
                Bash,
                typeof(global::G.BashTool),
                Computer,
                typeof(global::G.ComputerTool),
                TextEditor,
                typeof(global::G.TextEditorTool),
                Query,
                typeof(global::G.QueryTool),
                GoogleCalendarEventCreate,
                typeof(global::G.GoogleCalendarCreateEventTool),
                GoogleSheetsRowAppend,
                typeof(global::G.GoogleSheetsRowAppendTool),
                GoogleCalendarAvailabilityCheck,
                typeof(global::G.GoogleCalendarCheckAvailabilityTool),
                SlackMessageSend,
                typeof(global::G.SlackSendMessageTool),
                Sms,
                typeof(global::G.SmsTool),
                Mcp,
                typeof(global::G.McpTool),
                GohighlevelCalendarAvailabilityCheck,
                typeof(global::G.GoHighLevelCalendarAvailabilityTool),
                GohighlevelCalendarEventCreate,
                typeof(global::G.GoHighLevelCalendarEventCreateTool),
                GohighlevelContactCreate,
                typeof(global::G.GoHighLevelContactCreateTool),
                GohighlevelContactGet,
                typeof(global::G.GoHighLevelContactGetTool),
                SipRequest,
                typeof(global::G.SipRequestTool),
                Voicemail,
                typeof(global::G.VoicemailTool),
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
        public bool Equals(ToolControllerUpdateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ApiRequestTool?>.Default.Equals(ApiRequest, other.ApiRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeTool?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DtmfTool?>.Default.Equals(Dtmf, other.Dtmf) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EndCallTool?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GhlTool?>.Default.Equals(Ghl, other.Ghl) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferCallTool?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HandoffTool?>.Default.Equals(Handoff, other.Handoff) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BashTool?>.Default.Equals(Bash, other.Bash) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerTool?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextEditorTool?>.Default.Equals(TextEditor, other.TextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::G.QueryTool?>.Default.Equals(Query, other.Query) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GoogleCalendarCreateEventTool?>.Default.Equals(GoogleCalendarEventCreate, other.GoogleCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GoogleSheetsRowAppendTool?>.Default.Equals(GoogleSheetsRowAppend, other.GoogleSheetsRowAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GoogleCalendarCheckAvailabilityTool?>.Default.Equals(GoogleCalendarAvailabilityCheck, other.GoogleCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SlackSendMessageTool?>.Default.Equals(SlackMessageSend, other.SlackMessageSend) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SmsTool?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::G.McpTool?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GoHighLevelCalendarAvailabilityTool?>.Default.Equals(GohighlevelCalendarAvailabilityCheck, other.GohighlevelCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GoHighLevelCalendarEventCreateTool?>.Default.Equals(GohighlevelCalendarEventCreate, other.GohighlevelCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GoHighLevelContactCreateTool?>.Default.Equals(GohighlevelContactCreate, other.GohighlevelContactCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GoHighLevelContactGetTool?>.Default.Equals(GohighlevelContactGet, other.GohighlevelContactGet) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SipRequestTool?>.Default.Equals(SipRequest, other.SipRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VoicemailTool?>.Default.Equals(Voicemail, other.Voicemail) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolControllerUpdateResponse obj1, ToolControllerUpdateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolControllerUpdateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolControllerUpdateResponse obj1, ToolControllerUpdateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolControllerUpdateResponse o && Equals(o);
        }
    }
}
