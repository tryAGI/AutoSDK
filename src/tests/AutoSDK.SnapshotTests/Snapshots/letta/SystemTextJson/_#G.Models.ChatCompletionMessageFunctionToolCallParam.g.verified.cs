//HintName: G.Models.ChatCompletionMessageFunctionToolCallParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A call to a function tool created by the model.
    /// </summary>
    public sealed partial class ChatCompletionMessageFunctionToolCallParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The function that the model called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"function"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "function";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageFunctionToolCallParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="function">
        /// The function that the model called.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageFunctionToolCallParam(
            string id,
            global::G.OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction function,
            string type = "function")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageFunctionToolCallParam" /> class.
        /// </summary>
        public ChatCompletionMessageFunctionToolCallParam()
        {
        }
    }
}