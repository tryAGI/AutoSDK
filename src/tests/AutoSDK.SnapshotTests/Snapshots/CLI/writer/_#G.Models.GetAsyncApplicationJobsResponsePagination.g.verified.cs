//HintName: G.Models.GetAsyncApplicationJobsResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAsyncApplicationJobsResponsePagination
    {
        /// <summary>
        /// The pagination offset for retrieving the jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// The pagination limit for retrieving the jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAsyncApplicationJobsResponsePagination" /> class.
        /// </summary>
        /// <param name="offset">
        /// The pagination offset for retrieving the jobs.
        /// </param>
        /// <param name="limit">
        /// The pagination limit for retrieving the jobs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAsyncApplicationJobsResponsePagination(
            long? offset,
            int? limit)
        {
            this.Offset = offset;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAsyncApplicationJobsResponsePagination" /> class.
        /// </summary>
        public GetAsyncApplicationJobsResponsePagination()
        {
        }
    }
}