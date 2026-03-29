//HintName: G.Models.CompletionPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionPrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContentItem> Content { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_variables")]
        public global::System.Collections.Generic.IList<string>? InputVariables { get; set; }

        /// <summary>
        /// Default Value: f-string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_format")]
        public global::G.CompletionPromptTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// Default Value: completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CompletionPromptType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionPrompt" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="inputVariables">
        /// Default Value: []
        /// </param>
        /// <param name="templateFormat">
        /// Default Value: f-string
        /// </param>
        /// <param name="type">
        /// Default Value: completion
        /// </param>
        public CompletionPrompt(
            global::System.Collections.Generic.IList<global::G.ContentItem> content,
            global::System.Collections.Generic.IList<string>? inputVariables,
            global::G.CompletionPromptTemplateFormat? templateFormat,
            global::G.CompletionPromptType? type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.InputVariables = inputVariables;
            this.TemplateFormat = templateFormat;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionPrompt" /> class.
        /// </summary>
        public CompletionPrompt()
        {
        }
    }
}