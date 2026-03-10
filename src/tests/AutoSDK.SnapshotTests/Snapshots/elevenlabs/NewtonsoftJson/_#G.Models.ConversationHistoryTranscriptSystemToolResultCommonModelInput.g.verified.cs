//HintName: G.Models.ConversationHistoryTranscriptSystemToolResultCommonModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptSystemToolResultCommonModelInput
    {
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
        [global::Newtonsoft.Json.JsonProperty("result_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResultValue { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_has_been_called", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ToolHasBeenCalled { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_latency_secs")]
        public double? ToolLatencySecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_error_message")]
        public string? RawErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variable_updates")]
        public global::System.Collections.Generic.IList<global::G.DynamicVariableUpdateCommonModel>? DynamicVariableUpdates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"system"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "system";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.ResultVariant1? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptSystemToolResultCommonModelInput" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="toolName"></param>
        /// <param name="resultValue"></param>
        /// <param name="isError"></param>
        /// <param name="toolHasBeenCalled"></param>
        /// <param name="toolLatencySecs">
        /// Default Value: 0
        /// </param>
        /// <param name="errorType"></param>
        /// <param name="rawErrorMessage"></param>
        /// <param name="dynamicVariableUpdates"></param>
        /// <param name="type"></param>
        /// <param name="result"></param>
        public ConversationHistoryTranscriptSystemToolResultCommonModelInput(
            string requestId,
            string toolName,
            string resultValue,
            bool isError,
            bool toolHasBeenCalled,
            double? toolLatencySecs,
            string? errorType,
            string? rawErrorMessage,
            global::System.Collections.Generic.IList<global::G.DynamicVariableUpdateCommonModel>? dynamicVariableUpdates,
            global::G.ResultVariant1? result,
            string type = "system")
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ResultValue = resultValue ?? throw new global::System.ArgumentNullException(nameof(resultValue));
            this.IsError = isError;
            this.ToolHasBeenCalled = toolHasBeenCalled;
            this.ToolLatencySecs = toolLatencySecs;
            this.ErrorType = errorType;
            this.RawErrorMessage = rawErrorMessage;
            this.DynamicVariableUpdates = dynamicVariableUpdates;
            this.Type = type;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptSystemToolResultCommonModelInput" /> class.
        /// </summary>
        public ConversationHistoryTranscriptSystemToolResultCommonModelInput()
        {
        }
    }
}