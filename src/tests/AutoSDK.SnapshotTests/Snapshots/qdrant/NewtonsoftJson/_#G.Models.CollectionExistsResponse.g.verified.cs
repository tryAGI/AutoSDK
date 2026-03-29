//HintName: G.Models.CollectionExistsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionExistsResponse
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// Time spent to process this request<br/>
        /// Example: 0.002F
        /// </summary>
        /// <example>0.002F</example>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public float? Time { get; set; }

        /// <summary>
        /// Example: ok
        /// </summary>
        /// <example>ok</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// State of existence of a collection, true = exists, false = does not exist
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.CollectionExistence? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionExistsResponse" /> class.
        /// </summary>
        /// <param name="usage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="time">
        /// Time spent to process this request<br/>
        /// Example: 0.002F
        /// </param>
        /// <param name="status">
        /// Example: ok
        /// </param>
        /// <param name="result">
        /// State of existence of a collection, true = exists, false = does not exist
        /// </param>
        public CollectionExistsResponse(
            global::G.Usage? usage,
            float? time,
            string? status,
            global::G.CollectionExistence? result)
        {
            this.Usage = usage;
            this.Time = time;
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionExistsResponse" /> class.
        /// </summary>
        public CollectionExistsResponse()
        {
        }
    }
}