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
        [global::Newtonsoft.Json.JsonProperty("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Example: 17939
        /// </summary>
        /// <example>17939</example>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domains")]
        public global::System.Collections.Generic.IList<string>? Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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