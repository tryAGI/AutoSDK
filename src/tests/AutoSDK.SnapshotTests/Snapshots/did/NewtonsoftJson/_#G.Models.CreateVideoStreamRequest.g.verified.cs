//HintName: G.Models.CreateVideoStreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoStreamRequest
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
        public global::G.AnyOf<global::G.CreateVideoStreamRequestScriptText, global::G.CreateVideoStreamRequestScriptAudio> Script { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoStreamRequest" /> class.
        /// </summary>
        /// <param name="script"></param>
        /// <param name="sessionId"></param>
        public CreateVideoStreamRequest(
            global::G.AnyOf<global::G.CreateVideoStreamRequestScriptText, global::G.CreateVideoStreamRequestScriptAudio> script,
            string? sessionId)
        {
            this.SessionId = sessionId;
            this.Script = script;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoStreamRequest" /> class.
        /// </summary>
        public CreateVideoStreamRequest()
        {
        }
    }
}