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
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.PromptVersionsFilterNode? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeExperimentVersions")]
        public bool? IncludeExperimentVersions { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersiosQueryParamsCompiled" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="filter"></param>
        /// <param name="includeExperimentVersions"></param>
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