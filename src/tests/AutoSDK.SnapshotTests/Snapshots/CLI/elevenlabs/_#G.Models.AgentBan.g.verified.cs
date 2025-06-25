//HintName: G.Models.AgentBan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentBan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BanReasonTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BanReasonType ReasonType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBan" /> class.
        /// </summary>
        /// <param name="atUnix"></param>
        /// <param name="reason"></param>
        /// <param name="reasonType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBan(
            int atUnix,
            global::G.BanReasonType reasonType,
            string? reason)
        {
            this.AtUnix = atUnix;
            this.ReasonType = reasonType;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBan" /> class.
        /// </summary>
        public AgentBan()
        {
        }
    }
}