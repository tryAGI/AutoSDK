//HintName: G.Models.SessionLogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionLogResponse
    {
        /// <summary>
        /// milliseconds that have elapsed since the UNIX epoch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public object Result { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rawBody", Required = global::Newtonsoft.Json.Required.Always)]
        public string RawBody { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLogResponse" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="rawBody"></param>
        /// <param name="timestamp">
        /// milliseconds that have elapsed since the UNIX epoch
        /// </param>
        public SessionLogResponse(
            object result,
            string rawBody,
            long? timestamp)
        {
            this.Timestamp = timestamp;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.RawBody = rawBody ?? throw new global::System.ArgumentNullException(nameof(rawBody));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLogResponse" /> class.
        /// </summary>
        public SessionLogResponse()
        {
        }
    }
}