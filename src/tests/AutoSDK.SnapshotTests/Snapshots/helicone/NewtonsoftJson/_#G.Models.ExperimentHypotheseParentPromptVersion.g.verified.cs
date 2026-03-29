//HintName: G.Models.ExperimentHypotheseParentPromptVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentHypotheseParentPromptVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template", Required = global::Newtonsoft.Json.Required.Always)]
        public object Template { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentHypotheseParentPromptVersion" /> class.
        /// </summary>
        /// <param name="template"></param>
        public ExperimentHypotheseParentPromptVersion(
            object template)
        {
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentHypotheseParentPromptVersion" /> class.
        /// </summary>
        public ExperimentHypotheseParentPromptVersion()
        {
        }
    }
}