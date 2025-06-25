//HintName: G.Models.BatchRequestInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The per-line object of the batch input file
    /// </summary>
    public sealed partial class BatchRequestInput
    {
        /// <summary>
        /// A developer-provided per-request id that will be used to match outputs to inputs. Must be unique for each request in a batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// The HTTP method to be used for the request. Currently only `POST` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchRequestInputMethodJsonConverter))]
        public global::G.BatchRequestInputMethod? Method { get; set; }

        /// <summary>
        /// The OpenAI API relative URL to be used for the request. Currently `/v1/chat/completions`, `/v1/embeddings`, and `/v1/completions` are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestInput" /> class.
        /// </summary>
        /// <param name="customId">
        /// A developer-provided per-request id that will be used to match outputs to inputs. Must be unique for each request in a batch.
        /// </param>
        /// <param name="method">
        /// The HTTP method to be used for the request. Currently only `POST` is supported.
        /// </param>
        /// <param name="url">
        /// The OpenAI API relative URL to be used for the request. Currently `/v1/chat/completions`, `/v1/embeddings`, and `/v1/completions` are supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRequestInput(
            string? customId,
            global::G.BatchRequestInputMethod? method,
            string? url)
        {
            this.CustomId = customId;
            this.Method = method;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestInput" /> class.
        /// </summary>
        public BatchRequestInput()
        {
        }
    }
}