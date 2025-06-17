//HintName: G.Models.ConversationHistoryTranscriptToolCallCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptToolCallCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params_as_json", Required = global::Newtonsoft.Json.Required.Always)]
        public string ParamsAsJson { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_has_been_called", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ToolHasBeenCalled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_details")]
        public global::G.ToolDetails? ToolDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallCommonModel" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="requestId"></param>
        /// <param name="toolName"></param>
        /// <param name="paramsAsJson"></param>
        /// <param name="toolHasBeenCalled"></param>
        /// <param name="toolDetails"></param>
        public ConversationHistoryTranscriptToolCallCommonModel(
            string requestId,
            string toolName,
            string paramsAsJson,
            bool toolHasBeenCalled,
            string? type,
            global::G.ToolDetails? toolDetails)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ParamsAsJson = paramsAsJson ?? throw new global::System.ArgumentNullException(nameof(paramsAsJson));
            this.ToolHasBeenCalled = toolHasBeenCalled;
            this.Type = type;
            this.ToolDetails = toolDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallCommonModel" /> class.
        /// </summary>
        public ConversationHistoryTranscriptToolCallCommonModel()
        {
        }
    }
}