//HintName: G.Models.UnifiedCreateVideoStreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnifiedCreateVideoStreamRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.UnifiedCreateVideoStreamRequestScriptText, global::G.UnifiedCreateVideoStreamRequestScriptAudio>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.UnifiedCreateVideoStreamRequestScriptText, global::G.UnifiedCreateVideoStreamRequestScriptAudio> Script { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedCreateVideoStreamRequest" /> class.
        /// </summary>
        /// <param name="script"></param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnifiedCreateVideoStreamRequest(
            global::G.AnyOf<global::G.UnifiedCreateVideoStreamRequestScriptText, global::G.UnifiedCreateVideoStreamRequestScriptAudio> script,
            string? sessionId)
        {
            this.SessionId = sessionId;
            this.Script = script;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedCreateVideoStreamRequest" /> class.
        /// </summary>
        public UnifiedCreateVideoStreamRequest()
        {
        }
    }
}