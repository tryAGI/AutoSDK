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
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.CreateVideoStreamRequestScriptText2, global::G.CreateVideoStreamRequestScriptAudio2> Script { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoStreamRequest2" /> class.
        /// </summary>
        /// <param name="script"></param>
        /// <param name="sessionId"></param>
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