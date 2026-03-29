//HintName: G.Models.RecommendQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recommend", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecommendInput Recommend { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendQuery" /> class.
        /// </summary>
        /// <param name="recommend"></param>
        public RecommendQuery(
            global::G.RecommendInput recommend)
        {
            this.Recommend = recommend ?? throw new global::System.ArgumentNullException(nameof(recommend));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendQuery" /> class.
        /// </summary>
        public RecommendQuery()
        {
        }
    }
}