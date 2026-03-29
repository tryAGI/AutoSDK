//HintName: G.Models.ResearchOperationDtoClassVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchOperationDtoClassVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResearchOperationDtoClassVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchType", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResearchOperationDtoClassVariant2SearchType SearchType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("goal")]
        public string? Goal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResearchOperationDtoClassVariant2Result> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PageTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOperationDtoClassVariant2" /> class.
        /// </summary>
        /// <param name="searchType"></param>
        /// <param name="query"></param>
        /// <param name="results"></param>
        /// <param name="pageTokens"></param>
        /// <param name="type"></param>
        /// <param name="goal"></param>
        public ResearchOperationDtoClassVariant2(
            global::G.ResearchOperationDtoClassVariant2SearchType searchType,
            string query,
            global::System.Collections.Generic.IList<global::G.ResearchOperationDtoClassVariant2Result> results,
            double pageTokens,
            global::G.ResearchOperationDtoClassVariant2Type type,
            string? goal)
        {
            this.Type = type;
            this.SearchType = searchType;
            this.Goal = goal;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.PageTokens = pageTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOperationDtoClassVariant2" /> class.
        /// </summary>
        public ResearchOperationDtoClassVariant2()
        {
        }
    }
}