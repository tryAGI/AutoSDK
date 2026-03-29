//HintName: G.Models.PromptVersionsQueryParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionsQueryParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.PromptVersionsFilterNode? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeExperimentVersions")]
        public bool? IncludeExperimentVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionsQueryParams" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includeExperimentVersions"></param>
        public PromptVersionsQueryParams(
            global::G.PromptVersionsFilterNode? filter,
            bool? includeExperimentVersions)
        {
            this.Filter = filter;
            this.IncludeExperimentVersions = includeExperimentVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionsQueryParams" /> class.
        /// </summary>
        public PromptVersionsQueryParams()
        {
        }
    }
}