//HintName: G.Models.CostsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aggregated costs details of the specific time bucket.
    /// </summary>
    public sealed partial class CostsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CostsResultObjectJsonConverter))]
        public global::G.CostsResultObject Object { get; set; }

        /// <summary>
        /// The monetary value in its associated currency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public global::G.CostsResultAmount? Amount { get; set; }

        /// <summary>
        /// When `group_by=line_item`, this field provides the line item of the grouped costs result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_item")]
        public string? LineItem { get; set; }

        /// <summary>
        /// When `group_by=project_id`, this field provides the project ID of the grouped costs result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostsResult" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="amount">
        /// The monetary value in its associated currency.
        /// </param>
        /// <param name="lineItem">
        /// When `group_by=line_item`, this field provides the line item of the grouped costs result.
        /// </param>
        /// <param name="projectId">
        /// When `group_by=project_id`, this field provides the project ID of the grouped costs result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostsResult(
            global::G.CostsResultObject @object,
            global::G.CostsResultAmount? amount,
            string? lineItem,
            string? projectId)
        {
            this.Object = @object;
            this.Amount = amount;
            this.LineItem = lineItem;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostsResult" /> class.
        /// </summary>
        public CostsResult()
        {
        }
    }
}