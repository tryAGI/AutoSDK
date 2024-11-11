//HintName: G.Models.DomainsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainsResponse
    {
        /// <summary>
        /// Example: 1.1.1.1
        /// </summary>
        /// <example>1.1.1.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Example: 17939
        /// </summary>
        /// <example>17939</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<string>? Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainsResponse" /> class.
        /// </summary>
        /// <param name="ip">
        /// Example: 1.1.1.1
        /// </param>
        /// <param name="page">
        /// Example: 1
        /// </param>
        /// <param name="total">
        /// Example: 17939
        /// </param>
        /// <param name="domains"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DomainsResponse(
            int total,
            string? ip,
            int? page,
            global::System.Collections.Generic.IList<string>? domains)
        {
            this.Total = total;
            this.Ip = ip;
            this.Page = page;
            this.Domains = domains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainsResponse" /> class.
        /// </summary>
        public DomainsResponse()
        {
        }
    }
}