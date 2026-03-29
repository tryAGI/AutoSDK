//HintName: G.Models.SearchRequestPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequestPayload
    {
        /// <summary>
        /// Specifies whether to include unindexed data in the search results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_level")]
        public global::G.ReadLevel? ReadLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searches", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SearchPayload> Searches { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestPayload" /> class.
        /// </summary>
        /// <param name="searches"></param>
        /// <param name="readLevel">
        /// Specifies whether to include unindexed data in the search results.
        /// </param>
        public SearchRequestPayload(
            global::System.Collections.Generic.IList<global::G.SearchPayload> searches,
            global::G.ReadLevel? readLevel)
        {
            this.ReadLevel = readLevel;
            this.Searches = searches ?? throw new global::System.ArgumentNullException(nameof(searches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestPayload" /> class.
        /// </summary>
        public SearchRequestPayload()
        {
        }
    }
}