//HintName: G.Models.FeedsListFeedsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsListFeedsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feeds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FeedsListFeedsResponseFeed> Feeds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_next_page", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListFeedsResponse" /> class.
        /// </summary>
        /// <param name="feeds"></param>
        /// <param name="hasNextPage"></param>
        public FeedsListFeedsResponse(
            global::System.Collections.Generic.IList<global::G.FeedsListFeedsResponseFeed> feeds,
            bool hasNextPage)
        {
            this.Feeds = feeds ?? throw new global::System.ArgumentNullException(nameof(feeds));
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListFeedsResponse" /> class.
        /// </summary>
        public FeedsListFeedsResponse()
        {
        }
    }
}