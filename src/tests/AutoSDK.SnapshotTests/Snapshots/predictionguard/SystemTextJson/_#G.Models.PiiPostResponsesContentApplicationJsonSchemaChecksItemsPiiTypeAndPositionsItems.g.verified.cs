//HintName: G.Models.PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems
    {
        /// <summary>
        /// The starting index of the pii item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public int? Start { get; set; }

        /// <summary>
        /// The ending index of the pii item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public int? End { get; set; }

        /// <summary>
        /// The type of the pii item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems" /> class.
        /// </summary>
        /// <param name="start">
        /// The starting index of the pii item.
        /// </param>
        /// <param name="end">
        /// The ending index of the pii item.
        /// </param>
        /// <param name="type">
        /// The type of the pii item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems(
            int? start,
            int? end,
            string? type)
        {
            this.Start = start;
            this.End = end;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems" /> class.
        /// </summary>
        public PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems()
        {
        }
    }
}