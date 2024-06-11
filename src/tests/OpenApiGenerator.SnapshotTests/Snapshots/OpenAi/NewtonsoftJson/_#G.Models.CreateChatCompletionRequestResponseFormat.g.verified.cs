//HintName: G.Models.CreateChatCompletionRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object specifying the format that the model must output. Compatible with [GPT-4 Turbo](/docs/models/gpt-4-and-gpt-4-turbo) and all GPT-3.5 Turbo models newer than `gpt-3.5-turbo-1106`.
    /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.
    /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestResponseFormat
    {
        /// <summary>
        /// Must be one of `text` or `json_object`.
        /// <br/>Default Value: text
        /// <br/>Example: json_object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateChatCompletionRequestResponseFormatType? Type { get; set; } = global::G.CreateChatCompletionRequestResponseFormatType.Text;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}