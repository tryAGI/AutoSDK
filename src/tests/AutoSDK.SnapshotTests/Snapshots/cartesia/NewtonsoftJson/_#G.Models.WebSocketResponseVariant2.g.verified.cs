//HintName: G.Models.WebSocketResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSocketResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebSocketResponseVariant2TypeJsonConverter))]
        public global::G.WebSocketResponseVariant2Type Type { get; set; }

        /// <summary>
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_id")]
        public string? ContextId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("done", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Done { get; set; } = default!;

        /// <summary>
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1.<br/>
        /// This can be used to map chunks of audio to certain transcript submissions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flush_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int FlushId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flush_done", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FlushDone { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketResponseVariant2" /> class.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="done"></param>
        /// <param name="flushId">
        /// An identifier corresponding to the number of flush commands that have been sent for this context. Starts at 1.<br/>
        /// This can be used to map chunks of audio to certain transcript submissions.
        /// </param>
        /// <param name="flushDone"></param>
        /// <param name="type"></param>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </param>
        public WebSocketResponseVariant2(
            int statusCode,
            bool done,
            int flushId,
            bool flushDone,
            global::G.WebSocketResponseVariant2Type type,
            string? contextId)
        {
            this.Type = type;
            this.ContextId = contextId;
            this.StatusCode = statusCode;
            this.Done = done;
            this.FlushId = flushId;
            this.FlushDone = flushDone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketResponseVariant2" /> class.
        /// </summary>
        public WebSocketResponseVariant2()
        {
        }
    }
}