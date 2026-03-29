//HintName: G.Models.ToolNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolNode
    {
        /// <summary>
        /// This is the Tool node. This can be used to call a tool in your workflow.<br/>
        /// The flow is:<br/>
        /// - Workflow starts the tool node<br/>
        /// - Model is called to extract parameters needed by the tool from the conversation history<br/>
        /// - Tool is called with the parameters<br/>
        /// - Server returns a response<br/>
        /// - Workflow continues with the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolNodeType Type { get; set; }

        /// <summary>
        /// This is the tool to call. To use an existing tool, send `toolId` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool")]
        public global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>? Tool { get; set; }

        /// <summary>
        /// This is the tool to call. To use a transient tool, send `tool` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolId")]
        public string? ToolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is whether or not the node is the start of the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isStart")]
        public bool? IsStart { get; set; }

        /// <summary>
        /// This is for metadata you want to store on the task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolNode" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// This is the Tool node. This can be used to call a tool in your workflow.<br/>
        /// The flow is:<br/>
        /// - Workflow starts the tool node<br/>
        /// - Model is called to extract parameters needed by the tool from the conversation history<br/>
        /// - Tool is called with the parameters<br/>
        /// - Server returns a response<br/>
        /// - Workflow continues with the response
        /// </param>
        /// <param name="tool">
        /// This is the tool to call. To use an existing tool, send `toolId` instead.
        /// </param>
        /// <param name="toolId">
        /// This is the tool to call. To use a transient tool, send `tool` instead.
        /// </param>
        /// <param name="isStart">
        /// This is whether or not the node is the start of the workflow.
        /// </param>
        /// <param name="metadata">
        /// This is for metadata you want to store on the task.
        /// </param>
        public ToolNode(
            string name,
            global::G.ToolNodeType type,
            global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>? tool,
            string? toolId,
            bool? isStart,
            object? metadata)
        {
            this.Type = type;
            this.Tool = tool;
            this.ToolId = toolId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsStart = isStart;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolNode" /> class.
        /// </summary>
        public ToolNode()
        {
        }
    }
}