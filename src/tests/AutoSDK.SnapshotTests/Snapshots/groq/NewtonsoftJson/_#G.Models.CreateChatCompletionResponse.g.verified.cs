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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset Created { get; set; } = default!;

        /// <summary>
        /// The model used for the chat completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionResponseObjectJsonConverter))]
        public global::G.CreateChatCompletionResponseObject Object { get; set; }

        /// <summary>
        /// Usage statistics for the completion request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.CompletionUsage? Usage { get; set; }

        /// <summary>
        /// Usage statistics for compound AI completion requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_breakdown")]
        public global::G.ChatCompletionUsageBreakdown? UsageBreakdown { get; set; }

        /// <summary>
        /// The service tier used for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionResponseServiceTierJsonConverter))]
        public global::G.CreateChatCompletionResponseServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// List of discovered MCP tools from connected servers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_list_tools")]
        public global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponseMcpListTool>? McpListTools { get; set; }

        /// <summary>
        /// Groq-specific metadata for non-streaming chat completion responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x_groq")]
        public global::G.XGroqNonStreaming? XGroq { get; set; }

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
        /// <param name="usageBreakdown">
        /// Usage statistics for compound AI completion requests.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used for the request.
        /// </param>
        /// <param name="mcpListTools">
        /// List of discovered MCP tools from connected servers.
        /// </param>
        /// <param name="xGroq">
        /// Groq-specific metadata for non-streaming chat completion responses.
        /// </param>
        public CreateChatCompletionResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponseChoice> choices,
            global::System.DateTimeOffset created,
            string model,
            string? systemFingerprint,
            global::G.CreateChatCompletionResponseObject @object,
            global::G.CompletionUsage? usage,
            global::G.ChatCompletionUsageBreakdown? usageBreakdown,
            global::G.CreateChatCompletionResponseServiceTier? serviceTier,
            global::System.Collections.Generic.IList<global::G.CreateChatCompletionResponseMcpListTool>? mcpListTools,
            global::G.XGroqNonStreaming? xGroq)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SystemFingerprint = systemFingerprint;
            this.Object = @object;
            this.Usage = usage;
            this.UsageBreakdown = usageBreakdown;
            this.ServiceTier = serviceTier;
            this.McpListTools = mcpListTools;
            this.XGroq = xGroq;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponse" /> class.
        /// </summary>
        public CreateChatCompletionResponse()
        {
        }
    }
}