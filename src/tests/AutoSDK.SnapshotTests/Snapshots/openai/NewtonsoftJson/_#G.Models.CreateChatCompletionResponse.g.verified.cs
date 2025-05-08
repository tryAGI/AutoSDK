//HintName: G.Models.CreateChatCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a chat completion response returned by model, based on the provided input.
    /// </summary>
    public sealed partial class CreateChatCompletionResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A list of chat completion choices. Can be more than one if `n` is greater than 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponseChoice> Choices { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the chat completion was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset Created { get; set; } = default!;

        /// <summary>
        /// The model used for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
        ///   - If set to 'auto', and the Project is Scale tier enabled, the system<br/>
        ///     will utilize scale tier credits until they are exhausted.<br/>
        ///   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'flex', the request will be processed with the Flex Processing service tier. [Learn more](/docs/guides/flex-processing).<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        ///   When this parameter is set, the response body will include the `service_tier` utilized.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        public global::G.ServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// The object type, which is always `chat.completion`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.CreateChatCompletionResponseObject Object { get; set; }

        /// <summary>
        /// Usage statistics for the completion request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.CompletionUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chat completion.
        /// </param>
        /// <param name="choices">
        /// A list of chat completion choices. Can be more than one if `n` is greater than 1.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp (in seconds) of when the chat completion was created.
        /// </param>
        /// <param name="model">
        /// The model used for the chat completion.
        /// </param>
        /// <param name="serviceTier">
        /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
        ///   - If set to 'auto', and the Project is Scale tier enabled, the system<br/>
        ///     will utilize scale tier credits until they are exhausted.<br/>
        ///   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
        ///   - If set to 'flex', the request will be processed with the Flex Processing service tier. [Learn more](/docs/guides/flex-processing).<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        ///   When this parameter is set, the response body will include the `service_tier` utilized.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="systemFingerprint">
        /// This fingerprint represents the backend configuration that the model runs with.<br/>
        /// Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `chat.completion`.
        /// </param>
        /// <param name="usage">
        /// Usage statistics for the completion request.
        /// </param>
        public CreateChatCompletionResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponseChoice> choices,
            global::System.DateTimeOffset created,
            string model,
            global::G.ServiceTier? serviceTier,
            string? systemFingerprint,
            global::G.CreateChatCompletionResponseObject @object,
            global::G.CompletionUsage? usage)
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
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponse" /> class.
        /// </summary>
        public CreateChatCompletionResponse()
        {
        }
    }
}