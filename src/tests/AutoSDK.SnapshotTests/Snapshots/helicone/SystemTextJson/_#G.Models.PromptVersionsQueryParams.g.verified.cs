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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptVersionsFilterNodeJsonConverter))]
        public global::G.PromptVersionsFilterNode? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeExperimentVersions")]
        public bool? IncludeExperimentVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionsQueryParams" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includeExperimentVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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