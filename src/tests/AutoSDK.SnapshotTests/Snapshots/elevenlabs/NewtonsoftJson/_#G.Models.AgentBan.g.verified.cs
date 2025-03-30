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
        [global::Newtonsoft.Json.JsonProperty("at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int AtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BanReasonType ReasonType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBan" /> class.
        /// </summary>
        /// <param name="atUnix"></param>
        /// <param name="reason"></param>
        /// <param name="reasonType"></param>
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