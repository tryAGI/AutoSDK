//HintName: G.Models.FeedsListMessagesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsListMessagesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FeedsListMessagesResponseMessage> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_next_page", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public double? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListMessagesResponse" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="hasNextPage"></param>
        /// <param name="nextCursor"></param>
        public FeedsListMessagesResponse(
            global::System.Collections.Generic.IList<global::G.FeedsListMessagesResponseMessage> messages,
            bool hasNextPage,
            double? nextCursor)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.HasNextPage = hasNextPage;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListMessagesResponse" /> class.
        /// </summary>
        public FeedsListMessagesResponse()
        {
        }
    }
}