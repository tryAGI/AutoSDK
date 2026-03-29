//HintName: G.Models.ToolCallHookAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallHookAction
    {
        /// <summary>
        /// This is the type of action - must be "tool"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolCallHookActionTypeJsonConverter))]
        public global::G.ToolCallHookActionType Type { get; set; }

        /// <summary>
        /// This is the tool to call. To use an existing tool, send `toolId` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>))]
        public global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>? Tool { get; set; }

        /// <summary>
        /// This is the tool to call. To use a transient tool, send `tool` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolId")]
        public string? ToolId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallHookAction" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of action - must be "tool"
        /// </param>
        /// <param name="tool">
        /// This is the tool to call. To use an existing tool, send `toolId` instead.
        /// </param>
        /// <param name="toolId">
        /// This is the tool to call. To use a transient tool, send `tool` instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallHookAction(
            global::G.ToolCallHookActionType type,
            global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>? tool,
            string? toolId)
        {
            this.Type = type;
            this.Tool = tool;
            this.ToolId = toolId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallHookAction" /> class.
        /// </summary>
        public ToolCallHookAction()
        {
        }
    }
}