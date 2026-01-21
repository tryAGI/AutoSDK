//HintName: G.Models.OpenAIChatCompletionsInMaxTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The maximum number of tokens to generate in the chat completion.<br/>
    /// The total length of input tokens and generated tokens is limited by the model's context length. If explicitly set to None it will be the model's max context length minus input length or 16384, whichever is smaller.
    /// </summary>
    public sealed partial class OpenAIChatCompletionsInMaxTokens
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}