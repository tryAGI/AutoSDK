//HintName: G.Models.WordSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"id":"d5a3d302-066e-43fb-b63b-8f57baf185db","total_count":10,"matches":[{"text":"smoke","count":6,"timestamps":[[250,650],[49168,49398],[55284,55594],[168888,169118],[215108,215386],[225944,226170]],"indexes":[0,136,156,486,652,698]},{"text":"wildfires","count":4,"timestamps":[[1668,2346],[33852,34546],[50118,51110],[231356,232354]],"indexes":[4,90,140,716]}]}
    /// </summary>
    public sealed partial class WordSearchResponse
    {
        /// <summary>
        /// The ID of the transcript
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The total count of all matched instances. For e.g., word 1 matched 2 times, and word 2 matched 3 times, `total_count` will equal 5.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// The matches of the search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("matches", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WordSearchMatch> Matches { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordSearchResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the transcript
        /// </param>
        /// <param name="totalCount">
        /// The total count of all matched instances. For e.g., word 1 matched 2 times, and word 2 matched 3 times, `total_count` will equal 5.
        /// </param>
        /// <param name="matches">
        /// The matches of the search
        /// </param>
        public WordSearchResponse(
            global::System.Guid id,
            int totalCount,
            global::System.Collections.Generic.IList<global::G.WordSearchMatch> matches)
        {
            this.Id = id;
            this.TotalCount = totalCount;
            this.Matches = matches ?? throw new global::System.ArgumentNullException(nameof(matches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordSearchResponse" /> class.
        /// </summary>
        public WordSearchResponse()
        {
        }
    }
}