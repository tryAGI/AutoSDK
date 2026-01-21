//HintName: G.Models.ChatCompletion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used for non-streaming responses. Streaming responses return `ChatCompletionVllmStreamingMessage`.
    /// </summary>
    public sealed partial class ChatCompletion
    {
        /// <summary>
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// One or more responses, depending on the `n` parameter from the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionResponseChoice> Choices { get; set; }

        /// <summary>
        /// The token counts for this request. Per-token billing is based on the<br/>
        /// prompt token and completion token counts and rates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UsageInfo Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletion" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="choices">
        /// One or more responses, depending on the `n` parameter from the request.
        /// </param>
        /// <param name="usage">
        /// The token counts for this request. Per-token billing is based on the<br/>
        /// prompt token and completion token counts and rates.
        /// </param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletion(
            string id,
            global::System.Collections.Generic.IList<global::G.ChatCompletionResponseChoice> choices,
            global::G.UsageInfo usage,
            object? meta)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletion" /> class.
        /// </summary>
        public ChatCompletion()
        {
        }
    }
}