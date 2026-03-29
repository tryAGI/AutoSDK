//HintName: G.Models.RateLimitsPolicyListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitsPolicyListResponse
    {
        /// <summary>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.RateLimitsPolicy>? Data { get; set; }

        /// <summary>
        /// Total number of policies
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsPolicyListResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: list
        /// </param>
        /// <param name="data"></param>
        /// <param name="total">
        /// Total number of policies
        /// </param>
        public RateLimitsPolicyListResponse(
            string? @object,
            global::System.Collections.Generic.IList<global::G.RateLimitsPolicy>? data,
            int? total)
        {
            this.Object = @object;
            this.Data = data;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitsPolicyListResponse" /> class.
        /// </summary>
        public RateLimitsPolicyListResponse()
        {
        }
    }
}