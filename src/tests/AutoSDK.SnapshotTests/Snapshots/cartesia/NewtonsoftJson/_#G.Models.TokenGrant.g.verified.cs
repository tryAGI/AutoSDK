//HintName: G.Models.TokenGrant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenGrant
    {
        /// <summary>
        /// The `tts` grant allows the token to be used to access any TTS endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tts")]
        public bool? Tts { get; set; }

        /// <summary>
        /// The `stt` grant allows the token to be used to access any STT endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stt")]
        public bool? Stt { get; set; }

        /// <summary>
        /// The `agent` grant allows the token to be used to access the Agent websocket calling [endpoint](/line/integrations/web-calls#connection).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public bool? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenGrant" /> class.
        /// </summary>
        /// <param name="tts">
        /// The `tts` grant allows the token to be used to access any TTS endpoint.
        /// </param>
        /// <param name="stt">
        /// The `stt` grant allows the token to be used to access any STT endpoint.
        /// </param>
        /// <param name="agent">
        /// The `agent` grant allows the token to be used to access the Agent websocket calling [endpoint](/line/integrations/web-calls#connection).
        /// </param>
        public TokenGrant(
            bool? tts,
            bool? stt,
            bool? agent)
        {
            this.Tts = tts;
            this.Stt = stt;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenGrant" /> class.
        /// </summary>
        public TokenGrant()
        {
        }
    }
}