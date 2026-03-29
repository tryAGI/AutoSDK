//HintName: G.Models.CodeTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeToolTypeJsonConverter))]
        public global::G.CodeToolType Type { get; set; }

        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Describes what this tool does and when to call this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// Determines whether the agent would say sentence like "One moment, let me check that." when executing the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// Determines whether the agent would call LLM another time and speak when the result of function is obtained.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speak_after_execution")]
        public bool? SpeakAfterExecution { get; set; }

        /// <summary>
        /// The description for the sentence agent say during execution. Only applicable when speak_during_execution is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeToolExecutionMessageTypeJsonConverter))]
        public global::G.CodeToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </param>
        /// <param name="code">
        /// JavaScript code to execute in the sandbox.
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what this tool does and when to call this tool.
        /// </param>
        /// <param name="timeoutMs">
        /// The maximum time in milliseconds the code can run before it's considered timeout. Defaults to 30,000 ms (30 s).
        /// </param>
        /// <param name="responseVariables">
        /// A mapping of variable names to JSON paths in the code execution result. These mapped values will be extracted and added as dynamic variables.<br/>
        /// Example: {"order_id":"data.order.id"}
        /// </param>
        /// <param name="speakDuringExecution">
        /// Determines whether the agent would say sentence like "One moment, let me check that." when executing the tool.
        /// </param>
        /// <param name="speakAfterExecution">
        /// Determines whether the agent would call LLM another time and speak when the result of function is obtained.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="executionMessageDescription">
        /// The description for the sentence agent say during execution. Only applicable when speak_during_execution is true.
        /// </param>
        /// <param name="executionMessageType">
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeTool(
            string name,
            string code,
            global::G.CodeToolType type,
            string? description,
            int? timeoutMs,
            global::System.Collections.Generic.Dictionary<string, string>? responseVariables,
            bool? speakDuringExecution,
            bool? speakAfterExecution,
            string? executionMessageDescription,
            global::G.CodeToolExecutionMessageType? executionMessageType)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.TimeoutMs = timeoutMs;
            this.ResponseVariables = responseVariables;
            this.SpeakDuringExecution = speakDuringExecution;
            this.SpeakAfterExecution = speakAfterExecution;
            this.ExecutionMessageDescription = executionMessageDescription;
            this.ExecutionMessageType = executionMessageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeTool" /> class.
        /// </summary>
        public CodeTool()
        {
        }
    }
}