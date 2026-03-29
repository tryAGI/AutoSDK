//HintName: G.Models.WebSocketTTSOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSocketTTSOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_timestamps")]
        public global::G.WordTimestamps? WordTimestamps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneme_timestamps")]
        public global::G.PhonemeTimestamps? PhonemeTimestamps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public object? Audio { get; set; }

        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1.<br/>
        /// This can be used to map chunks of audio to certain transcript submissions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flush_id")]
        public int? FlushId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flush_done")]
        public bool? FlushDone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketTTSOutput" /> class.
        /// </summary>
        /// <param name="wordTimestamps"></param>
        /// <param name="phonemeTimestamps"></param>
        /// <param name="audio"></param>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </param>
        /// <param name="flushId">
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1.<br/>
        /// This can be used to map chunks of audio to certain transcript submissions.
        /// </param>
        /// <param name="flushDone"></param>
        public WebSocketTTSOutput(
            global::G.WordTimestamps? wordTimestamps,
            global::G.PhonemeTimestamps? phonemeTimestamps,
            object? audio,
            string? contextId,
            int? flushId,
            bool? flushDone)
        {
            this.WordTimestamps = wordTimestamps;
            this.PhonemeTimestamps = phonemeTimestamps;
            this.Audio = audio;
            this.ContextId = contextId;
            this.FlushId = flushId;
            this.FlushDone = flushDone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketTTSOutput" /> class.
        /// </summary>
        public WebSocketTTSOutput()
        {
        }
    }
}