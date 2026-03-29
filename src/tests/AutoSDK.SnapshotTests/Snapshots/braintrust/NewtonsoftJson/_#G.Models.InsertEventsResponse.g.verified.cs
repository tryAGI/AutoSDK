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
        [global::Newtonsoft.Json.JsonProperty("row_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RowIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertEventsResponse" /> class.
        /// </summary>
        /// <param name="rowIds">
        /// The ids of all rows that were inserted, aligning one-to-one with the rows provided as input
        /// </param>
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