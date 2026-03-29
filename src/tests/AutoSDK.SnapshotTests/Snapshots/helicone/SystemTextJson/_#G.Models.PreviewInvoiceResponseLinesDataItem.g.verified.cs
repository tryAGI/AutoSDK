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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponseLinesDataItem" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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