//HintName: G.Models.VoicemailActionHangup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicemailActionHangup
    {
        /// <summary>
        /// Example: hangup
        /// </summary>
        /// <example>hangup</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VoicemailActionHangupTypeJsonConverter))]
        public global::G.VoicemailActionHangupType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionHangup" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: hangup
        /// </param>
        public VoicemailActionHangup(
            global::G.VoicemailActionHangupType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionHangup" /> class.
        /// </summary>
        public VoicemailActionHangup()
        {
        }
    }
}