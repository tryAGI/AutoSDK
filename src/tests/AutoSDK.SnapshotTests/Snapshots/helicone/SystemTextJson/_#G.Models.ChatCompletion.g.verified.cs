//HintName: G.Models.ChatCompletion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a chat completion response returned by model, based on the provided<br/>
    /// input.
    /// </summary>
    public sealed partial class ChatCompletion
    {
        /// <summary>
        /// A unique identifier for the chat completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A list of chat completion choices. Can be more than one if `n` is greater<br/>
        /// than 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionChoice> Choices { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the chat completion was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

        /// <summary>
        /// The model used for the chat completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The object type, which is always `chat.completion`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionObjectJsonConverter))]
        public global::G.ChatCompletionObject Object { get; set; }

        /// <summary>
        /// Specifies the processing type used for serving the request.<br/>
        /// - If set to 'auto', then the request will be processed with the service tier<br/>
        ///   configured in the Project settings. Unless otherwise configured, the Project<br/>
        ///   will use 'default'.<br/>
        /// - If set to 'default', then the request will be processed with the standard<br/>
        ///   pricing and performance for the selected model.<br/>
        /// - If set to '[flex](https://platform.openai.com/docs/guides/flex-processing)' or<br/>
        ///   'priority', then the request will be processed with the corresponding service<br/>
        ///   tier. [Contact sales](https://openai.com/contact-sales) to learn more about<br/>
        ///   Priority processing.<br/>
        /// - When not set, the default behavior is 'auto'.<br/>
        /// When the `service_tier` parameter is set, the response body will include the<br/>
        /// `service_tier` value based on the processing mode actually used to serve the<br/>
        /// request. This response value may be different from the value set in the<br/>
        /// parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionServiceTierJsonConverter))]
        public global::G.ChatCompletionServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when<br/>
        /// backend changes have been made that might impact determinism.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// Usage statistics for the completion request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.CompletionUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletion" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chat completion.
        /// </param>
        /// <param name="choices">
        /// A list of chat completion choices. Can be more than one if `n` is greater<br/>
        /// than 1.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp (in seconds) of when the chat completion was created.
        /// </param>
        /// <param name="model">
        /// The model used for the chat completion.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `chat.completion`.
        /// </param>
        /// <param name="serviceTier">
        /// Specifies the processing type used for serving the request.<br/>
        /// - If set to 'auto', then the request will be processed with the service tier<br/>
        ///   configured in the Project settings. Unless otherwise configured, the Project<br/>
        ///   will use 'default'.<br/>
        /// - If set to 'default', then the request will be processed with the standard<br/>
        ///   pricing and performance for the selected model.<br/>
        /// - If set to '[flex](https://platform.openai.com/docs/guides/flex-processing)' or<br/>
        ///   'priority', then the request will be processed with the corresponding service<br/>
        ///   tier. [Contact sales](https://openai.com/contact-sales) to learn more about<br/>
        ///   Priority processing.<br/>
        /// - When not set, the default behavior is 'auto'.<br/>
        /// When the `service_tier` parameter is set, the response body will include the<br/>
        /// `service_tier` value based on the processing mode actually used to serve the<br/>
        /// request. This response value may be different from the value set in the<br/>
        /// parameter.
        /// </param>
        /// <param name="systemFingerprint">
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when<br/>
        /// backend changes have been made that might impact determinism.
        /// </param>
        /// <param name="usage">
        /// Usage statistics for the completion request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletion(
            string id,
            global::System.Collections.Generic.IList<global::G.ChatCompletionChoice> choices,
            double created,
            string model,
            global::G.ChatCompletionObject @object,
            global::G.ChatCompletionServiceTier? serviceTier,
            string? systemFingerprint,
            global::G.CompletionUsage? usage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.ServiceTier = serviceTier;
            this.SystemFingerprint = systemFingerprint;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletion" /> class.
        /// </summary>
        public ChatCompletion()
        {
        }
    }
}