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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The seed used for the request. See the seed property on CreateChatCompletionRequest for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional Groq-specific usage metrics (hardware cache statistics).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.XGroqNonStreamingUsage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debug")]
        public global::G.DebugData? Debug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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