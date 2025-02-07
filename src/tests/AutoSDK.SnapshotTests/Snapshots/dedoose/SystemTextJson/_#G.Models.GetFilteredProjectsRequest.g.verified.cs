//HintName: G.Models.GetFilteredProjectsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFilteredProjectsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxResults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilteredProjectsRequest" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFilteredProjectsRequest(
            string filter,
            int maxResults)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilteredProjectsRequest" /> class.
        /// </summary>
        public GetFilteredProjectsRequest()
        {
        }
    }
}