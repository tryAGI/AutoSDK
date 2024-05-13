﻿//HintName: G.Models.CreateChatCompletionStreamResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a streamed chunk of a chat completion response returned by model, based on the provided input.
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion. Each chunk has the same ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A list of chat completion choices. Can contain more than one elements if `n` is greater than 1. Can also be empty for the
        /// last chunk if you set `stream_options: {"include_usage": true}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<CreateChatCompletionStreamResponseChoices> Choices { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the chat completion was created. Each chunk has the same timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public int Created { get; set; } = default!;

        /// <summary>
        /// The model to generate the completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// The object type, which is always `chat.completion.chunk`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public CreateChatCompletionStreamResponseObject Object { get; set; } = default!;

        /// <summary>
        /// An optional field that will only be present when you set `stream_options: {"include_usage": true}` in your request.
        /// When present, it contains a null value except for the last chunk which contains the token usage statistics for the entire request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public CreateChatCompletionStreamResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}