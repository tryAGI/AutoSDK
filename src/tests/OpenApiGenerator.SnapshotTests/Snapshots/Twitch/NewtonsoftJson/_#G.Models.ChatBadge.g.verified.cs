//HintName: G.Models.ChatBadge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatBadge
    {
        /// <summary>
        /// An ID that identifies this set of chat badges. For example, Bits or Subscriber.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("set_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SetId { get; set; } = default!;

        /// <summary>
        /// The list of chat badges in this set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatBadgeVersion> Versions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}