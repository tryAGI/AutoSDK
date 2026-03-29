//HintName: G.Models.ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_trunc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAtTrunc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Property { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem" /> class.
        /// </summary>
        /// <param name="createdAtTrunc"></param>
        /// <param name="requestCount"></param>
        /// <param name="totalCost"></param>
        /// <param name="property"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem(
            string createdAtTrunc,
            double requestCount,
            double totalCost,
            string property)
        {
            this.CreatedAtTrunc = createdAtTrunc ?? throw new global::System.ArgumentNullException(nameof(createdAtTrunc));
            this.RequestCount = requestCount;
            this.TotalCost = totalCost;
            this.Property = property ?? throw new global::System.ArgumentNullException(nameof(property));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayDataItem()
        {
        }
    }
}