//HintName: G.Models.TraceThreadLlmAsJudgeCodeWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceThreadLlmAsJudgeCodeWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LlmAsJudgeModelParametersWrite Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LlmAsJudgeMessageWrite> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LlmAsJudgeOutputSchemaWrite> Schema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadLlmAsJudgeCodeWrite" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="schema"></param>
        public TraceThreadLlmAsJudgeCodeWrite(
            global::G.LlmAsJudgeModelParametersWrite model,
            global::System.Collections.Generic.IList<global::G.LlmAsJudgeMessageWrite> messages,
            global::System.Collections.Generic.IList<global::G.LlmAsJudgeOutputSchemaWrite> schema)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThreadLlmAsJudgeCodeWrite" /> class.
        /// </summary>
        public TraceThreadLlmAsJudgeCodeWrite()
        {
        }
    }
}