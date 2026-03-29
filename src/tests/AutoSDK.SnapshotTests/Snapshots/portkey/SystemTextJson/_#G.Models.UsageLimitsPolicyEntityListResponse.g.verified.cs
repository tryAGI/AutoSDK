//HintName: G.Models.UsageLimitsPolicyEntityListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageLimitsPolicyEntityListResponse
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
        public global::System.Collections.Generic.IList<global::G.UsageLimitsPolicyEntity>? Data { get; set; }

        /// <summary>
        /// Total number of entities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicyEntityListResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: list
        /// </param>
        /// <param name="data"></param>
        /// <param name="total">
        /// Total number of entities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageLimitsPolicyEntityListResponse(
            string? @object,
            global::System.Collections.Generic.IList<global::G.UsageLimitsPolicyEntity>? data,
            int? total)
        {
            this.Object = @object;
            this.Data = data;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicyEntityListResponse" /> class.
        /// </summary>
        public UsageLimitsPolicyEntityListResponse()
        {
        }
    }
}