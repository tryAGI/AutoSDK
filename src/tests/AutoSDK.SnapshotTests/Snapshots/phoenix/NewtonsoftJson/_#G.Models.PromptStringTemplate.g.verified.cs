//HintName: G.Models.PromptStringTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptStringTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"string"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "string";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template", Required = global::Newtonsoft.Json.Required.Always)]
        public string Template { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptStringTemplate" /> class.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="type"></param>
        public PromptStringTemplate(
            string template,
            string type = "string")
        {
            this.Type = type;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptStringTemplate" /> class.
        /// </summary>
        public PromptStringTemplate()
        {
        }
    }
}