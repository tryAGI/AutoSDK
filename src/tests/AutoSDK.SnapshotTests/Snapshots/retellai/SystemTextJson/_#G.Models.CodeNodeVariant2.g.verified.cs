//HintName: G.Models.CodeNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeNodeVariant2TypeJsonConverter))]
        public global::G.CodeNodeVariant2Type Type { get; set; }

        /// <summary>
        /// JavaScript code to execute in the sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The maximum time in milliseconds the code can run before it's considered timeout. Defaults to 30,000 ms (30 s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// A mapping of variable names to JSON paths in the code execution result. These mapped values will be extracted and added as dynamic variables.<br/>
        /// Example: {"order_id":"data.order.id"}
        /// </summary>
        /// <example>{"order_id":"data.order.id"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? ResponseVariables { get; set; }

        /// <summary>
        /// Whether to speak during code execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NodeInstructionJsonConverter))]
        public global::G.NodeInstruction? Instruction { get; set; }

        /// <summary>
        /// Whether to wait for code execution result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_for_result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WaitForResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::G.NodeEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("else_edge")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ElseEdgeJsonConverter))]
        public global::G.ElseEdge? ElseEdge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_transition_examples")]
        public global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? FinetuneTransitionExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeNodeVariant2" /> class.
        /// </summary>
        /// <param name="code">
        /// JavaScript code to execute in the sandbox.
        /// </param>
        /// <param name="waitForResult">
        /// Whether to wait for code execution result
        /// </param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="timeoutMs">
        /// The maximum time in milliseconds the code can run before it's considered timeout. Defaults to 30,000 ms (30 s).
        /// </param>
        /// <param name="responseVariables">
        /// A mapping of variable names to JSON paths in the code execution result. These mapped values will be extracted and added as dynamic variables.<br/>
        /// Example: {"order_id":"data.order.id"}
        /// </param>
        /// <param name="speakDuringExecution">
        /// Whether to speak during code execution
        /// </param>
        /// <param name="instruction"></param>
        /// <param name="edges"></param>
        /// <param name="elseEdge"></param>
        /// <param name="finetuneTransitionExamples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeNodeVariant2(
            string code,
            bool waitForResult,
            global::G.CodeNodeVariant2Type type,
            int? timeoutMs,
            global::System.Collections.Generic.Dictionary<string, string>? responseVariables,
            bool? speakDuringExecution,
            global::G.NodeInstruction? instruction,
            global::System.Collections.Generic.IList<global::G.NodeEdge>? edges,
            global::G.ElseEdge? elseEdge,
            global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? finetuneTransitionExamples)
        {
            this.Type = type;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.TimeoutMs = timeoutMs;
            this.ResponseVariables = responseVariables;
            this.SpeakDuringExecution = speakDuringExecution;
            this.Instruction = instruction;
            this.WaitForResult = waitForResult;
            this.Edges = edges;
            this.ElseEdge = elseEdge;
            this.FinetuneTransitionExamples = finetuneTransitionExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeNodeVariant2" /> class.
        /// </summary>
        public CodeNodeVariant2()
        {
        }
    }
}