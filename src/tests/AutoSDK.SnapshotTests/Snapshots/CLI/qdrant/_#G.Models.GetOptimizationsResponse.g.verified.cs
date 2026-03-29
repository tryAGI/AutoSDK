//HintName: G.Models.GetOptimizationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOptimizationsResponse
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// Time spent to process this request<br/>
        /// Example: 0.002F
        /// </summary>
        /// <example>0.002F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public float? Time { get; set; }

        /// <summary>
        /// Example: ok
        /// </summary>
        /// <example>ok</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Optimizations progress for the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.OptimizationsResponse? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOptimizationsResponse" /> class.
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
        /// Optimizations progress for the collection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOptimizationsResponse(
            global::G.Usage? usage,
            float? time,
            string? status,
            global::G.OptimizationsResponse? result)
        {
            this.Usage = usage;
            this.Time = time;
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOptimizationsResponse" /> class.
        /// </summary>
        public GetOptimizationsResponse()
        {
        }
    }
}