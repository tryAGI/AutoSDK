//HintName: G.Models.PromptVersionData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_provider", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelProvider ModelProvider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Template2 Template { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptTemplateType TemplateType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptTemplateFormat TemplateFormat { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invocation_parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InvocationParameters2 InvocationParameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::G.PromptTools? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.ResponseFormatVariant12? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionData" /> class.
        /// </summary>
        /// <param name="modelProvider"></param>
        /// <param name="modelName"></param>
        /// <param name="template"></param>
        /// <param name="templateType"></param>
        /// <param name="templateFormat"></param>
        /// <param name="invocationParameters"></param>
        /// <param name="description"></param>
        /// <param name="tools"></param>
        /// <param name="responseFormat"></param>
        public PromptVersionData(
            global::G.ModelProvider modelProvider,
            string modelName,
            global::G.Template2 template,
            global::G.PromptTemplateType templateType,
            global::G.PromptTemplateFormat templateFormat,
            global::G.InvocationParameters2 invocationParameters,
            string? description,
            global::G.PromptTools? tools,
            global::G.ResponseFormatVariant12? responseFormat)
        {
            this.Description = description;
            this.ModelProvider = modelProvider;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Template = template;
            this.TemplateType = templateType;
            this.TemplateFormat = templateFormat;
            this.InvocationParameters = invocationParameters;
            this.Tools = tools;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionData" /> class.
        /// </summary>
        public PromptVersionData()
        {
        }
    }
}