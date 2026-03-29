//HintName: G.Models.MetadataSendTelemetryRequestEventVariant5Data.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendTelemetryRequestEventVariant5Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_length", Required = global::Newtonsoft.Json.Required.Always)]
        public double InputLength { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_command", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsCommand { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("command_name")]
        public string? CommandName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MessageType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant5Data" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="inputLength"></param>
        /// <param name="isCommand"></param>
        /// <param name="messageType"></param>
        /// <param name="modelId"></param>
        /// <param name="agentId"></param>
        /// <param name="commandName"></param>
        public MetadataSendTelemetryRequestEventVariant5Data(
            string sessionId,
            double inputLength,
            bool isCommand,
            string messageType,
            string modelId,
            string? agentId,
            string? commandName)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.AgentId = agentId;
            this.InputLength = inputLength;
            this.IsCommand = isCommand;
            this.CommandName = commandName;
            this.MessageType = messageType ?? throw new global::System.ArgumentNullException(nameof(messageType));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant5Data" /> class.
        /// </summary>
        public MetadataSendTelemetryRequestEventVariant5Data()
        {
        }
    }
}