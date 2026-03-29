//HintName: G.Models.OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The function that the model called.
    /// </summary>
    public sealed partial class OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction(
            string arguments,
            string name)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction" /> class.
        /// </summary>
        public OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction()
        {
        }
    }
}