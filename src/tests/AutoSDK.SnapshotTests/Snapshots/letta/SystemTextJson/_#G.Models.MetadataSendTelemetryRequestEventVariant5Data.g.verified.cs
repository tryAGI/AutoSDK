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
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InputLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command_name")]
        public string? CommandName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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