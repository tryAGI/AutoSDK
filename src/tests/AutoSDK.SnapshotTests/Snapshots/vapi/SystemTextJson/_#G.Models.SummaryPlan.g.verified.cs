//HintName: G.Models.SummaryPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummaryPlan
    {
        /// <summary>
        /// These are the messages used to generate the summary.<br/>
        /// @default: ```<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "system",<br/>
        ///     "content": "You are an expert note-taker. You will be given a transcript of a call. Summarize the call in 2-3 sentences. DO NOT return anything except the summary."<br/>
        ///   },<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": "Here is the transcript:\n\n{{transcript}}\n\n. Here is the ended reason of the call:\n\n{{endedReason}}\n\n"<br/>
        ///   }<br/>
        /// ]```<br/>
        /// You can customize by providing any messages you want.<br/>
        /// Here are the template variables available:<br/>
        /// - {{transcript}}: The transcript of the call from `call.artifact.transcript` <br/>
        /// - {{systemPrompt}}: The system prompt of the call from `assistant.model.messages[type=system].content` <br/>
        /// - {{messages}}: The messages of the call from `assistant.model.messages` <br/>
        /// - {{endedReason}}: The ended reason of the call from `call.endedReason`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        /// This determines whether a summary is generated and stored in `call.analysis.summary`. Defaults to true.<br/>
        /// Usage:<br/>
        /// - If you want to disable the summary, set this to false.<br/>
        /// @default true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This is how long the request is tried before giving up. When request times out, `call.analysis.summary` will be empty.<br/>
        /// Usage:<br/>
        /// - To guarantee the summary is generated, set this value high. Note, this will delay the end of call report in cases where model is slow to respond.<br/>
        /// @default 5 seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryPlan" /> class.
        /// </summary>
        /// <param name="messages">
        /// These are the messages used to generate the summary.<br/>
        /// @default: ```<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "system",<br/>
        ///     "content": "You are an expert note-taker. You will be given a transcript of a call. Summarize the call in 2-3 sentences. DO NOT return anything except the summary."<br/>
        ///   },<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": "Here is the transcript:\n\n{{transcript}}\n\n. Here is the ended reason of the call:\n\n{{endedReason}}\n\n"<br/>
        ///   }<br/>
        /// ]```<br/>
        /// You can customize by providing any messages you want.<br/>
        /// Here are the template variables available:<br/>
        /// - {{transcript}}: The transcript of the call from `call.artifact.transcript` <br/>
        /// - {{systemPrompt}}: The system prompt of the call from `assistant.model.messages[type=system].content` <br/>
        /// - {{messages}}: The messages of the call from `assistant.model.messages` <br/>
        /// - {{endedReason}}: The ended reason of the call from `call.endedReason`
        /// </param>
        /// <param name="enabled">
        /// This determines whether a summary is generated and stored in `call.analysis.summary`. Defaults to true.<br/>
        /// Usage:<br/>
        /// - If you want to disable the summary, set this to false.<br/>
        /// @default true
        /// </param>
        /// <param name="timeoutSeconds">
        /// This is how long the request is tried before giving up. When request times out, `call.analysis.summary` will be empty.<br/>
        /// Usage:<br/>
        /// - To guarantee the summary is generated, set this value high. Note, this will delay the end of call report in cases where model is slow to respond.<br/>
        /// @default 5 seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryPlan(
            global::System.Collections.Generic.IList<object>? messages,
            bool? enabled,
            double? timeoutSeconds)
        {
            this.Messages = messages;
            this.Enabled = enabled;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryPlan" /> class.
        /// </summary>
        public SummaryPlan()
        {
        }
    }
}