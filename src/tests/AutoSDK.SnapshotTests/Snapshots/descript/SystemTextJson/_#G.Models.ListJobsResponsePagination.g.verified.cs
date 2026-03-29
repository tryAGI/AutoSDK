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
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsResponsePagination" /> class.
        /// </summary>
        /// <param name="nextCursor">
        /// Cursor for the next page of results. Absent if no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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