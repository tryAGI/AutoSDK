//HintName: G.Models.PreviewInvoiceResponseLinesDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewInvoiceResponseLinesDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponseLinesDataItem" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// <param name="id"></param>
        public PreviewInvoiceResponseLinesDataItem(
            string? description,
            double? amount,
            string? id)
        {
            this.Description = description;
            this.Amount = amount;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponseLinesDataItem" /> class.
        /// </summary>
        public PreviewInvoiceResponseLinesDataItem()
        {
        }
    }
}