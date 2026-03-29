//HintName: G.Models.QueryPointsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryPointsResponse
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.QueryResponse? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPointsResponse" /> class.
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
        /// <param name="result"></param>
        public QueryPointsResponse(
            global::G.Usage? usage,
            float? time,
            string? status,
            global::G.QueryResponse? result)
        {
            this.Usage = usage;
            this.Time = time;
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPointsResponse" /> class.
        /// </summary>
        public QueryPointsResponse()
        {
        }
    }
}