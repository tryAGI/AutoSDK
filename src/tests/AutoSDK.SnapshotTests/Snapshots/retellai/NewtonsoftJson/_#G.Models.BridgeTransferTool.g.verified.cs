//HintName: G.Models.BridgeTransferTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BridgeTransferTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BridgeTransferToolType Type { get; set; }

        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state transitions). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Describes what the tool does. This tool is only available to transfer agents (agents with isTransferAgent set to true) in agentic warm transfer mode. When invoked, it bridges the original caller to the transfer target and ends the transfer agent call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// If true, will speak during execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// Describes what to say to user when bridging the transfer. Only applicable when speak_during_execution is true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_type")]
        public global::G.BridgeTransferToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeTransferTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state transitions). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what the tool does. This tool is only available to transfer agents (agents with isTransferAgent set to true) in agentic warm transfer mode. When invoked, it bridges the original caller to the transfer target and ends the transfer agent call.
        /// </param>
        /// <param name="speakDuringExecution">
        /// If true, will speak during execution.
        /// </param>
        /// <param name="executionMessageDescription">
        /// Describes what to say to user when bridging the transfer. Only applicable when speak_during_execution is true.
        /// </param>
        /// <param name="executionMessageType">
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </param>
        public BridgeTransferTool(
            string name,
            global::G.BridgeTransferToolType type,
            string? description,
            bool? speakDuringExecution,
            string? executionMessageDescription,
            global::G.BridgeTransferToolExecutionMessageType? executionMessageType)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.SpeakDuringExecution = speakDuringExecution;
            this.ExecutionMessageDescription = executionMessageDescription;
            this.ExecutionMessageType = executionMessageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeTransferTool" /> class.
        /// </summary>
        public BridgeTransferTool()
        {
        }
    }
}