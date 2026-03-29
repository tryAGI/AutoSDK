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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ContentItem> Content { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        public global::System.Collections.Generic.IList<string>? InputVariables { get; set; }

        /// <summary>
        /// Default Value: f-string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompletionPromptTemplateFormatJsonConverter))]
        public global::G.CompletionPromptTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// Default Value: completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompletionPromptTypeJsonConverter))]
        public global::G.CompletionPromptType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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