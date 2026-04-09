//HintName: G.Models.VoicemailActionBridgeTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicemailActionBridgeTransfer
    {
        /// <summary>
        /// Example: bridge_transfer
        /// </summary>
        /// <example>bridge_transfer</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VoicemailActionBridgeTransferTypeJsonConverter))]
        public global::G.VoicemailActionBridgeTransferType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionBridgeTransfer" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: bridge_transfer
        /// </param>
        public VoicemailActionBridgeTransfer(
            global::G.VoicemailActionBridgeTransferType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailActionBridgeTransfer" /> class.
        /// </summary>
        public VoicemailActionBridgeTransfer()
        {
        }
    }
}