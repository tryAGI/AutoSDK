//HintName: G.Models.AgentRequestVoicemailOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If this option is set, the call will try to detect voicemail in the first 3 minutes of the call. Actions defined (hangup, or leave a message) will be applied when the voicemail is detected. Set this to null to disable voicemail detection.<br/>
    /// Example: {"action":{"type":"static_text","text":"Please give us a callback tomorrow at 10am."}}
    /// </summary>
    public sealed partial class AgentRequestVoicemailOption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoicemailActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VoicemailAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestVoicemailOption" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRequestVoicemailOption(
            global::G.VoicemailAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestVoicemailOption" /> class.
        /// </summary>
        public AgentRequestVoicemailOption()
        {
        }
    }
}