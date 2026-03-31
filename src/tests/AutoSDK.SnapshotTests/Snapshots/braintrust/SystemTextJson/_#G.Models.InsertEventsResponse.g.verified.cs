//HintName: G.Models.InsertEventsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsertEventsResponse
    {
        /// <summary>
        /// The ids of all rows that were inserted, aligning one-to-one with the rows provided as input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RowIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertEventsResponse" /> class.
        /// </summary>
        /// <param name="rowIds">
        /// The ids of all rows that were inserted, aligning one-to-one with the rows provided as input
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsertEventsResponse(
            global::System.Collections.Generic.IList<string> rowIds)
        {
            this.RowIds = rowIds ?? throw new global::System.ArgumentNullException(nameof(rowIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertEventsResponse" /> class.
        /// </summary>
        public InsertEventsResponse()
        {
        }
    }
}