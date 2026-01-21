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
        [global::Newtonsoft.Json.JsonProperty("hub_ref")]
        public string? HubRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::System.Collections.Generic.IList<byte[]>? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_format")]
        public string? TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variable_mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? VariableMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public object Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public EvaluatorStructuredOutput(
            object model,
            string? hubRef,
            global::System.Collections.Generic.IList<byte[]>? prompt,
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