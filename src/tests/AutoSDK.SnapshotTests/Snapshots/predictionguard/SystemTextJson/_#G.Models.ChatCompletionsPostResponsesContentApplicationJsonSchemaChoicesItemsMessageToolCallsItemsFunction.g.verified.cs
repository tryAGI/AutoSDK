//HintName: G.Models.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItemsFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The tool call function data.
    /// </summary>
    public sealed partial class ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItemsFunction
    {
        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The function arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItemsFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="arguments">
        /// The function arguments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItemsFunction(
            string? name,
            string? arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItemsFunction" /> class.
        /// </summary>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItemsFunction()
        {
        }
    }
}