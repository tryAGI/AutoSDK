//HintName: G.Models.XGroqNonStreaming.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groq-specific metadata for non-streaming chat completion responses.
    /// </summary>
    public sealed partial class XGroqNonStreaming
    {
        /// <summary>
        /// A groq request ID which can be used to refer to a specific request to groq support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The seed used for the request. See the seed property on CreateChatCompletionRequest for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional Groq-specific usage metrics (hardware cache statistics).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.XGroqNonStreamingUsage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public global::G.DebugData? Debug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XGroqNonStreaming" /> class.
        /// </summary>
        /// <param name="id">
        /// A groq request ID which can be used to refer to a specific request to groq support.
        /// </param>
        /// <param name="seed">
        /// The seed used for the request. See the seed property on CreateChatCompletionRequest for more details.
        /// </param>
        /// <param name="usage">
        /// Additional Groq-specific usage metrics (hardware cache statistics).
        /// </param>
        /// <param name="debug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XGroqNonStreaming(
            string id,
            int? seed,
            global::G.XGroqNonStreamingUsage? usage,
            global::G.DebugData? debug)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Seed = seed;
            this.Usage = usage;
            this.Debug = debug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XGroqNonStreaming" /> class.
        /// </summary>
        public XGroqNonStreaming()
        {
        }
    }
}