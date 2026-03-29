//HintName: G.Models.ListJobsResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListJobsResponsePagination
    {
        /// <summary>
        /// Cursor for the next page of results. Absent if no more results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsResponsePagination" /> class.
        /// </summary>
        /// <param name="nextCursor">
        /// Cursor for the next page of results. Absent if no more results.
        /// </param>
        public ListJobsResponsePagination(
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsResponsePagination" /> class.
        /// </summary>
        public ListJobsResponsePagination()
        {
        }
    }
}