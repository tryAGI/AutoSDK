//HintName: G.Models.ChatCompletionMessageFunctionToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A call to a function tool created by the model.
    /// </summary>
    public sealed partial class ChatCompletionMessageFunctionToolCall
    {
        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The function that the model called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionMessageFunctionToolCallFunction Function { get; set; }

        /// <summary>
        /// The type of the tool. Currently, only `function` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageFunctionToolCallTypeJsonConverter))]
        public global::G.ChatCompletionMessageFunctionToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageFunctionToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the tool call.
        /// </param>
        /// <param name="function">
        /// The function that the model called.
        /// </param>
        /// <param name="type">
        /// The type of the tool. Currently, only `function` is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageFunctionToolCall(
            string id,
            global::G.ChatCompletionMessageFunctionToolCallFunction function,
            global::G.ChatCompletionMessageFunctionToolCallType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageFunctionToolCall" /> class.
        /// </summary>
        public ChatCompletionMessageFunctionToolCall()
        {
        }
    }
}