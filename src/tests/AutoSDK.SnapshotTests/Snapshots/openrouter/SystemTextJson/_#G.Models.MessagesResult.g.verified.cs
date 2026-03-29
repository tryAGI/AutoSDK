//HintName: G.Models.MessagesResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Non-streaming response from the Anthropic Messages API with OpenRouter extensions
    /// </summary>
    public sealed partial class MessagesResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultTypeJsonConverter))]
        public global::G.BaseMessagesResultType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultRoleJsonConverter))]
        public global::G.BaseMessagesResultRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.BaseMessagesResultContainer, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.BaseMessagesResultContainer, object> Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItems> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.BaseMessagesResultStopReason?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.BaseMessagesResultStopReason?, object> StopReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessagesResultUsage Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesResultProviderJsonConverter))]
        public global::G.MessagesResultProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="container"></param>
        /// <param name="content"></param>
        /// <param name="model"></param>
        /// <param name="stopReason"></param>
        /// <param name="usage"></param>
        /// <param name="type"></param>
        /// <param name="role"></param>
        /// <param name="stopSequence"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResult(
            string id,
            global::G.OneOf<global::G.BaseMessagesResultContainer, object> container,
            global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItems> content,
            string model,
            global::G.OneOf<global::G.BaseMessagesResultStopReason?, object> stopReason,
            global::G.MessagesResultUsage usage,
            global::G.BaseMessagesResultType type,
            global::G.BaseMessagesResultRole role,
            string? stopSequence,
            global::G.MessagesResultProvider? provider)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Role = role;
            this.Container = container;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResult" /> class.
        /// </summary>
        public MessagesResult()
        {
        }
    }
}