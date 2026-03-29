//HintName: G.Models.StreamingResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.StreamingResponseVariant2Type Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingResponseVariant2" /> class.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="done"></param>
        /// <param name="type"></param>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </param>
        public StreamingResponseVariant2(
            int statusCode,
            bool done,
            global::G.StreamingResponseVariant2Type type,
            string? contextId)
        {
            this.Type = type;
            this.ContextId = contextId;
            this.StatusCode = statusCode;
            this.Done = done;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingResponseVariant2" /> class.
        /// </summary>
        public StreamingResponseVariant2()
        {
        }
    }
}