//HintName: G.Models.PaginatedPurchasedCredits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedPurchasedCredits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purchases", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PurchasedCredits> Purchases { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page", Required = global::Newtonsoft.Json.Required.Always)]
        public double Page { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageSize", Required = global::Newtonsoft.Json.Required.Always)]
        public double PageSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedPurchasedCredits" /> class.
        /// </summary>
        /// <param name="purchases"></param>
        /// <param name="total"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        public PaginatedPurchasedCredits(
            global::System.Collections.Generic.IList<global::G.PurchasedCredits> purchases,
            double total,
            double page,
            double pageSize)
        {
            this.Purchases = purchases ?? throw new global::System.ArgumentNullException(nameof(purchases));
            this.Total = total;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedPurchasedCredits" /> class.
        /// </summary>
        public PaginatedPurchasedCredits()
        {
        }
    }
}