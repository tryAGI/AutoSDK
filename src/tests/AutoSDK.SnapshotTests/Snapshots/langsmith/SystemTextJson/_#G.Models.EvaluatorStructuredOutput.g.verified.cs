//HintName: G.Models.EvaluatorStructuredOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Evaluator structured output schema.
    /// </summary>
    public sealed partial class EvaluatorStructuredOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hub_ref")]
        public string? HubRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        public string? TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? VariableMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStructuredOutput" /> class.
        /// </summary>
        /// <param name="hubRef"></param>
        /// <param name="prompt"></param>
        /// <param name="templateFormat"></param>
        /// <param name="schema"></param>
        /// <param name="variableMapping"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorStructuredOutput(
            object model,
            string? hubRef,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? prompt,
            string? templateFormat,
            object? schema,
            global::System.Collections.Generic.Dictionary<string, string>? variableMapping)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.HubRef = hubRef;
            this.Prompt = prompt;
            this.TemplateFormat = templateFormat;
            this.Schema = schema;
            this.VariableMapping = variableMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorStructuredOutput" /> class.
        /// </summary>
        public EvaluatorStructuredOutput()
        {
        }
    }
}