//HintName: G.Models.ChatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRequest
    {
        /// <summary>
        /// The chat message or question.<br/>
        /// Example: How can I use the Vectara platform?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The parameters to search one or more corpora.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SearchCorporaParametersJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SearchCorporaParameters Search { get; set; }

        /// <summary>
        /// The parameters to control generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public global::G.GenerationParameters? Generation { get; set; }

        /// <summary>
        /// Parameters to control chat behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public global::G.ChatParameters? Chat { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}