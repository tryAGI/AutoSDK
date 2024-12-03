//HintName: G.Models.GetGlobalChatBadgesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGlobalChatBadgesResponse
    {
        /// <summary>
        /// The list of chat badges. The list is sorted in ascending order by `set_id`, and within a set, the list is sorted in ascending order by `id`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatBadge> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGlobalChatBadgesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of chat badges. The list is sorted in ascending order by `set_id`, and within a set, the list is sorted in ascending order by `id`.
        /// </param>
        public GetGlobalChatBadgesResponse(
            global::System.Collections.Generic.IList<global::G.ChatBadge> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGlobalChatBadgesResponse" /> class.
        /// </summary>
        public GetGlobalChatBadgesResponse()
        {
        }
    }
}