//HintName: G.Models.SpanLlmAsJudgeCodePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanLlmAsJudgeCodePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LlmAsJudgeModelParametersPublic Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LlmAsJudgeMessagePublic> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Variables { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LlmAsJudgeOutputSchemaPublic> Schema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanLlmAsJudgeCodePublic" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="variables"></param>
        /// <param name="schema"></param>
        public SpanLlmAsJudgeCodePublic(
            global::G.LlmAsJudgeModelParametersPublic model,
            global::System.Collections.Generic.IList<global::G.LlmAsJudgeMessagePublic> messages,
            global::System.Collections.Generic.Dictionary<string, string> variables,
            global::System.Collections.Generic.IList<global::G.LlmAsJudgeOutputSchemaPublic> schema)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanLlmAsJudgeCodePublic" /> class.
        /// </summary>
        public SpanLlmAsJudgeCodePublic()
        {
        }
    }
}