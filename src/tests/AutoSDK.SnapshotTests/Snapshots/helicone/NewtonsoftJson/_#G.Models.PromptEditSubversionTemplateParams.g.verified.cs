//HintName: G.Models.PromptEditSubversionTemplateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptEditSubversionTemplateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("heliconeTemplate", Required = global::Newtonsoft.Json.Required.Always)]
        public object HeliconeTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentId")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEditSubversionTemplateParams" /> class.
        /// </summary>
        /// <param name="heliconeTemplate"></param>
        /// <param name="experimentId"></param>
        public PromptEditSubversionTemplateParams(
            object heliconeTemplate,
            string? experimentId)
        {
            this.HeliconeTemplate = heliconeTemplate ?? throw new global::System.ArgumentNullException(nameof(heliconeTemplate));
            this.ExperimentId = experimentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEditSubversionTemplateParams" /> class.
        /// </summary>
        public PromptEditSubversionTemplateParams()
        {
        }
    }
}