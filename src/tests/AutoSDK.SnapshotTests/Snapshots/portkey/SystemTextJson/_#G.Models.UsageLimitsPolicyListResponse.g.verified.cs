//HintName: G.Models.UsageLimitsPolicyListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageLimitsPolicyListResponse
    {
        /// <summary>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.UsageLimitsPolicy>? Data { get; set; }

        /// <summary>
        /// Total number of policies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicyListResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: list
        /// </param>
        /// <param name="data"></param>
        /// <param name="total">
        /// Total number of policies
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageLimitsPolicyListResponse(
            string? @object,
            global::System.Collections.Generic.IList<global::G.UsageLimitsPolicy>? data,
            int? total)
        {
            this.Object = @object;
            this.Data = data;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicyListResponse" /> class.
        /// </summary>
        public UsageLimitsPolicyListResponse()
        {
        }
    }
}