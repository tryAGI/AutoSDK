﻿//HintName: G.Models.CreateChatCompletionStreamResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a streamed chunk of a chat completion response returned<br/>
    /// by the model, based on the provided input. <br/>
    /// [Learn more](/docs/guides/streaming-responses).
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion. Each chunk has the same ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A list of chat completion choices. Can contain more than one elements if `n` is greater than 1. Can also be empty for the<br/>
        /// last chunk if you set `stream_options: {"include_usage": true}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateChatCompletionStreamResponseChoice> Choices { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the chat completion was created. Each chunk has the same timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset Created { get; set; } = default!;

        /// <summary>
        /// The model to generate the completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The service tier used for processing the request.<br/>
        /// Example: scale
        /// </summary>
        /// <example>scale</example>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        public global::G.CreateChatCompletionStreamResponseServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// The object type, which is always `chat.completion.chunk`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.CreateChatCompletionStreamResponseObject Object { get; set; }

        /// <summary>
        /// An optional field that will only be present when you set `stream_options: {"include_usage": true}` in your request.<br/>
        /// When present, it contains a null value except for the last chunk which contains the token usage statistics for the entire request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.CreateChatCompletionStreamResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chat completion. Each chunk has the same ID.
        /// </param>
        /// <param name="choices">
        /// A list of chat completion choices. Can contain more than one elements if `n` is greater than 1. Can also be empty for the<br/>
        /// last chunk if you set `stream_options: {"include_usage": true}`.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp (in seconds) of when the chat completion was created. Each chunk has the same timestamp.
        /// </param>
        /// <param name="model">
        /// The model to generate the completion.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used for processing the request.<br/>
        /// Example: scale
        /// </param>
        /// <param name="systemFingerprint">
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `chat.completion.chunk`.
        /// </param>
        /// <param name="usage">
        /// An optional field that will only be present when you set `stream_options: {"include_usage": true}` in your request.<br/>
        /// When present, it contains a null value except for the last chunk which contains the token usage statistics for the entire request.
        /// </param>
        public CreateChatCompletionStreamResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.CreateChatCompletionStreamResponseChoice> choices,
            global::System.DateTimeOffset created,
            string model,
            global::G.CreateChatCompletionStreamResponseServiceTier? serviceTier,
            string? systemFingerprint,
            global::G.CreateChatCompletionStreamResponseObject @object,
            global::G.CreateChatCompletionStreamResponseUsage? usage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ServiceTier = serviceTier;
            this.SystemFingerprint = systemFingerprint;
            this.Object = @object;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponse" /> class.
        /// </summary>
        public CreateChatCompletionStreamResponse()
        {
        }
    }
}