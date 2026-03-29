//HintName: G.Models.LettaRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaRequestConfig
    {
        /// <summary>
        /// Whether the server should parse specific tool call arguments (default `send_message`) as `AssistantMessage` objects.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_assistant_message")]
        public bool? UseAssistantMessage { get; set; }

        /// <summary>
        /// The name of the designated message tool.<br/>
        /// Default Value: send_message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant_message_tool_name")]
        public string? AssistantMessageToolName { get; set; }

        /// <summary>
        /// The name of the message argument in the designated message tool.<br/>
        /// Default Value: message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant_message_tool_kwarg")]
        public string? AssistantMessageToolKwarg { get; set; }

        /// <summary>
        /// Only return specified message types in the response. If `None` (default) returns all messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_return_message_types")]
        public global::System.Collections.Generic.IList<global::G.MessageType>? IncludeReturnMessageTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaRequestConfig" /> class.
        /// </summary>
        /// <param name="useAssistantMessage">
        /// Whether the server should parse specific tool call arguments (default `send_message`) as `AssistantMessage` objects.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="assistantMessageToolName">
        /// The name of the designated message tool.<br/>
        /// Default Value: send_message
        /// </param>
        /// <param name="assistantMessageToolKwarg">
        /// The name of the message argument in the designated message tool.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="includeReturnMessageTypes">
        /// Only return specified message types in the response. If `None` (default) returns all messages.
        /// </param>
        public LettaRequestConfig(
            bool? useAssistantMessage,
            string? assistantMessageToolName,
            string? assistantMessageToolKwarg,
            global::System.Collections.Generic.IList<global::G.MessageType>? includeReturnMessageTypes)
        {
            this.UseAssistantMessage = useAssistantMessage;
            this.AssistantMessageToolName = assistantMessageToolName;
            this.AssistantMessageToolKwarg = assistantMessageToolKwarg;
            this.IncludeReturnMessageTypes = includeReturnMessageTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaRequestConfig" /> class.
        /// </summary>
        public LettaRequestConfig()
        {
        }
    }
}