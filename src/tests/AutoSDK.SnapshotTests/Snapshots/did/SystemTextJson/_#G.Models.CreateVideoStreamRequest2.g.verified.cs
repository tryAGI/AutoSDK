//HintName: G.Models.CreateVideoStreamRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoStreamRequest2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateVideoStreamRequestScriptText2, global::G.CreateVideoStreamRequestScriptAudio2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CreateVideoStreamRequestScriptText2, global::G.CreateVideoStreamRequestScriptAudio2> Script { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoStreamRequest2" /> class.
        /// </summary>
        /// <param name="script"></param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoStreamRequest2(
            global::G.AnyOf<global::G.CreateVideoStreamRequestScriptText2, global::G.CreateVideoStreamRequestScriptAudio2> script,
            string? sessionId)
        {
            this.SessionId = sessionId;
            this.Script = script;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoStreamRequest2" /> class.
        /// </summary>
        public CreateVideoStreamRequest2()
        {
        }
    }
}