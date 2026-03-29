//HintName: G.Models.TransferPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferPlan
    {
        /// <summary>
        /// This configures how transfer is executed and the experience of the destination party receiving the call.<br/>
        /// Usage:<br/>
        /// - `blind-transfer`: The assistant forwards the call to the destination without any message or summary.<br/>
        /// - `blind-transfer-add-summary-to-sip-header`: The assistant forwards the call to the destination and adds a SIP header X-Transfer-Summary to the call to include the summary.<br/>
        /// - `warm-transfer-say-message`: The assistant dials the destination, delivers the `message` to the destination party, connects the customer, and leaves the call.<br/>
        /// - `warm-transfer-say-summary`: The assistant dials the destination, provides a summary of the call to the destination party, connects the customer, and leaves the call.<br/>
        /// - `warm-transfer-wait-for-operator-to-speak-first-and-then-say-message`: The assistant dials the destination, waits for the operator to speak, delivers the `message` to the destination party, and then connects the customer.<br/>
        /// - `warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary`: The assistant dials the destination, waits for the operator to speak, provides a summary of the call to the destination party, and then connects the customer.<br/>
        /// - `warm-transfer-twiml`: The assistant dials the destination, executes the twiml instructions on the destination call leg, connects the customer, and leaves the call.<br/>
        /// - `warm-transfer-experimental`: The assistant puts the customer on hold, dials the destination, and if the destination answers (and is human), delivers a message or summary before connecting the customer. If the destination is unreachable or not human (e.g., with voicemail detection), the assistant delivers the `fallbackMessage` to the customer and optionally ends the call.<br/>
        /// @default 'blind-transfer'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferPlanModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferPlanMode Mode { get; set; }

        /// <summary>
        /// This is the message the assistant will deliver to the destination party before connecting the customer.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `blind-transfer-add-summary-to-sip-header`, `warm-transfer-say-message`, `warm-transfer-wait-for-operator-to-speak-first-and-then-say-message`, or `warm-transfer-experimental`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::G.CustomMessage>))]
        public global::G.OneOf<string, global::G.CustomMessage>? Message { get; set; }

        /// <summary>
        /// This is the timeout in seconds for the warm-transfer-wait-for-operator-to-speak-first-and-then-say-message/summary<br/>
        /// @default 60<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// This specifies the SIP verb to use while transferring the call.<br/>
        /// - 'refer': Uses SIP REFER to transfer the call (default)<br/>
        /// - 'bye': Ends current call with SIP BYE<br/>
        /// - 'dial': Uses SIP DIAL to transfer the call<br/>
        /// Default Value: refer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipVerb")]
        public object? SipVerb { get; set; }

        /// <summary>
        /// This sets the timeout for the dial operation in seconds. This is the duration the call will ring before timing out.<br/>
        /// Only applicable when `sipVerb='dial'`. Not applicable for SIP REFER or BYE.<br/>
        /// @default 60<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialTimeout")]
        public double? DialTimeout { get; set; }

        /// <summary>
        /// This is the URL to an audio file played while the customer is on hold during transfer.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-experimental`.<br/>
        /// - Used when transferring calls to play hold audio for the customer.<br/>
        /// - Must be a publicly accessible URL to an audio file.<br/>
        /// - Supported formats: MP3 and WAV.<br/>
        /// - If not provided, the default hold audio will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("holdAudioUrl")]
        public string? HoldAudioUrl { get; set; }

        /// <summary>
        /// This is the URL to an audio file played after the warm transfer message or summary is delivered to the destination party.<br/>
        /// It can be used to play a custom sound like 'beep' to notify that the transfer is complete.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-experimental`.<br/>
        /// - Used when transferring calls to play hold audio for the destination party.<br/>
        /// - Must be a publicly accessible URL to an audio file.<br/>
        /// - Supported formats: MP3 and WAV.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferCompleteAudioUrl")]
        public string? TransferCompleteAudioUrl { get; set; }

        /// <summary>
        /// This is the plan for manipulating the message context before initiating the warm transfer.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-experimental`.<br/>
        /// - These messages will automatically be added to the transferAssistant's system message.<br/>
        /// - If 'none', we will not add any transcript to the transferAssistant's system message.<br/>
        /// - If you want to provide your own messages, use transferAssistant.model.messages instead.<br/>
        /// @default { type: 'all' }
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextEngineeringPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ContextEngineeringPlanLastNMessages, global::G.ContextEngineeringPlanNone, global::G.ContextEngineeringPlanAll>))]
        public global::G.OneOf<global::G.ContextEngineeringPlanLastNMessages, global::G.ContextEngineeringPlanNone, global::G.ContextEngineeringPlanAll>? ContextEngineeringPlan { get; set; }

        /// <summary>
        /// This is the TwiML instructions to execute on the destination call leg before connecting the customer.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-twiml`.<br/>
        /// - Supports only `Play`, `Say`, `Gather`, `Hangup` and `Pause` verbs.<br/>
        /// - Maximum length is 4096 characters.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// &lt;Say voice="alice" language="en-US"&gt;Hello, transferring a customer to you.&lt;/Say&gt;<br/>
        /// &lt;Pause length="2"/&gt;<br/>
        /// &lt;Say&gt;They called about billing questions.&lt;/Say&gt;<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twiml")]
        public string? Twiml { get; set; }

        /// <summary>
        /// This is the plan for generating a summary of the call to present to the destination party.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `blind-transfer-add-summary-to-sip-header` or `warm-transfer-say-summary` or `warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary` or `warm-transfer-experimental`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaryPlan")]
        public global::G.SummaryPlan? SummaryPlan { get; set; }

        /// <summary>
        /// This flag includes the sipHeaders from above in the refer to sip uri as url encoded query params.<br/>
        /// @default false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipHeadersInReferToEnabled")]
        public bool? SipHeadersInReferToEnabled { get; set; }

        /// <summary>
        /// This configures the fallback plan when the transfer fails (destination unreachable, busy, or not human).<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-experimental`.<br/>
        /// - If not provided when using `warm-transfer-experimental`, a default message will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackPlan")]
        public global::G.TransferFallbackPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferPlan" /> class.
        /// </summary>
        /// <param name="mode">
        /// This configures how transfer is executed and the experience of the destination party receiving the call.<br/>
        /// Usage:<br/>
        /// - `blind-transfer`: The assistant forwards the call to the destination without any message or summary.<br/>
        /// - `blind-transfer-add-summary-to-sip-header`: The assistant forwards the call to the destination and adds a SIP header X-Transfer-Summary to the call to include the summary.<br/>
        /// - `warm-transfer-say-message`: The assistant dials the destination, delivers the `message` to the destination party, connects the customer, and leaves the call.<br/>
        /// - `warm-transfer-say-summary`: The assistant dials the destination, provides a summary of the call to the destination party, connects the customer, and leaves the call.<br/>
        /// - `warm-transfer-wait-for-operator-to-speak-first-and-then-say-message`: The assistant dials the destination, waits for the operator to speak, delivers the `message` to the destination party, and then connects the customer.<br/>
        /// - `warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary`: The assistant dials the destination, waits for the operator to speak, provides a summary of the call to the destination party, and then connects the customer.<br/>
        /// - `warm-transfer-twiml`: The assistant dials the destination, executes the twiml instructions on the destination call leg, connects the customer, and leaves the call.<br/>
        /// - `warm-transfer-experimental`: The assistant puts the customer on hold, dials the destination, and if the destination answers (and is human), delivers a message or summary before connecting the customer. If the destination is unreachable or not human (e.g., with voicemail detection), the assistant delivers the `fallbackMessage` to the customer and optionally ends the call.<br/>
        /// @default 'blind-transfer'
        /// </param>
        /// <param name="message">
        /// This is the message the assistant will deliver to the destination party before connecting the customer.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `blind-transfer-add-summary-to-sip-header`, `warm-transfer-say-message`, `warm-transfer-wait-for-operator-to-speak-first-and-then-say-message`, or `warm-transfer-experimental`.
        /// </param>
        /// <param name="timeout">
        /// This is the timeout in seconds for the warm-transfer-wait-for-operator-to-speak-first-and-then-say-message/summary<br/>
        /// @default 60<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="sipVerb">
        /// This specifies the SIP verb to use while transferring the call.<br/>
        /// - 'refer': Uses SIP REFER to transfer the call (default)<br/>
        /// - 'bye': Ends current call with SIP BYE<br/>
        /// - 'dial': Uses SIP DIAL to transfer the call<br/>
        /// Default Value: refer
        /// </param>
        /// <param name="dialTimeout">
        /// This sets the timeout for the dial operation in seconds. This is the duration the call will ring before timing out.<br/>
        /// Only applicable when `sipVerb='dial'`. Not applicable for SIP REFER or BYE.<br/>
        /// @default 60<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="holdAudioUrl">
        /// This is the URL to an audio file played while the customer is on hold during transfer.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-experimental`.<br/>
        /// - Used when transferring calls to play hold audio for the customer.<br/>
        /// - Must be a publicly accessible URL to an audio file.<br/>
        /// - Supported formats: MP3 and WAV.<br/>
        /// - If not provided, the default hold audio will be used.
        /// </param>
        /// <param name="transferCompleteAudioUrl">
        /// This is the URL to an audio file played after the warm transfer message or summary is delivered to the destination party.<br/>
        /// It can be used to play a custom sound like 'beep' to notify that the transfer is complete.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-experimental`.<br/>
        /// - Used when transferring calls to play hold audio for the destination party.<br/>
        /// - Must be a publicly accessible URL to an audio file.<br/>
        /// - Supported formats: MP3 and WAV.
        /// </param>
        /// <param name="contextEngineeringPlan">
        /// This is the plan for manipulating the message context before initiating the warm transfer.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-experimental`.<br/>
        /// - These messages will automatically be added to the transferAssistant's system message.<br/>
        /// - If 'none', we will not add any transcript to the transferAssistant's system message.<br/>
        /// - If you want to provide your own messages, use transferAssistant.model.messages instead.<br/>
        /// @default { type: 'all' }
        /// </param>
        /// <param name="twiml">
        /// This is the TwiML instructions to execute on the destination call leg before connecting the customer.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-twiml`.<br/>
        /// - Supports only `Play`, `Say`, `Gather`, `Hangup` and `Pause` verbs.<br/>
        /// - Maximum length is 4096 characters.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// &lt;Say voice="alice" language="en-US"&gt;Hello, transferring a customer to you.&lt;/Say&gt;<br/>
        /// &lt;Pause length="2"/&gt;<br/>
        /// &lt;Say&gt;They called about billing questions.&lt;/Say&gt;<br/>
        /// ```
        /// </param>
        /// <param name="summaryPlan">
        /// This is the plan for generating a summary of the call to present to the destination party.<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `blind-transfer-add-summary-to-sip-header` or `warm-transfer-say-summary` or `warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary` or `warm-transfer-experimental`.
        /// </param>
        /// <param name="sipHeadersInReferToEnabled">
        /// This flag includes the sipHeaders from above in the refer to sip uri as url encoded query params.<br/>
        /// @default false
        /// </param>
        /// <param name="fallbackPlan">
        /// This configures the fallback plan when the transfer fails (destination unreachable, busy, or not human).<br/>
        /// Usage:<br/>
        /// - Used only when `mode` is `warm-transfer-experimental`.<br/>
        /// - If not provided when using `warm-transfer-experimental`, a default message will be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferPlan(
            global::G.TransferPlanMode mode,
            global::G.OneOf<string, global::G.CustomMessage>? message,
            double? timeout,
            object? sipVerb,
            double? dialTimeout,
            string? holdAudioUrl,
            string? transferCompleteAudioUrl,
            global::G.OneOf<global::G.ContextEngineeringPlanLastNMessages, global::G.ContextEngineeringPlanNone, global::G.ContextEngineeringPlanAll>? contextEngineeringPlan,
            string? twiml,
            global::G.SummaryPlan? summaryPlan,
            bool? sipHeadersInReferToEnabled,
            global::G.TransferFallbackPlan? fallbackPlan)
        {
            this.Mode = mode;
            this.Message = message;
            this.Timeout = timeout;
            this.SipVerb = sipVerb;
            this.DialTimeout = dialTimeout;
            this.HoldAudioUrl = holdAudioUrl;
            this.TransferCompleteAudioUrl = transferCompleteAudioUrl;
            this.ContextEngineeringPlan = contextEngineeringPlan;
            this.Twiml = twiml;
            this.SummaryPlan = summaryPlan;
            this.SipHeadersInReferToEnabled = sipHeadersInReferToEnabled;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferPlan" /> class.
        /// </summary>
        public TransferPlan()
        {
        }
    }
}