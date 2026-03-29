//HintName: G.Models.PromptVersiosQueryParamsCompiled.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersiosQueryParamsCompiled
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
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersiosQueryParamsCompiled" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="filter"></param>
        /// <param name="includeExperimentVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersiosQueryParamsCompiled(
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            global::G.PromptVersionsFilterNode? filter,
            bool? includeExperimentVersions)
        {
            this.Filter = filter;
            this.IncludeExperimentVersions = includeExperimentVersions;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersiosQueryParamsCompiled" /> class.
        /// </summary>
        public PromptVersiosQueryParamsCompiled()
        {
        }
    }
}