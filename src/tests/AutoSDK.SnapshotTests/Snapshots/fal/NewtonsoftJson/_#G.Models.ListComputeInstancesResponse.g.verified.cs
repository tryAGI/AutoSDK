//HintName: G.Models.ListComputeInstancesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of compute instances with pagination support
    /// </summary>
    public sealed partial class ListComputeInstancesResponse
    {
        /// <summary>
        /// Cursor for the next page of results, null if no more pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Array of compute instances belonging to the authenticated user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instances", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ListComputeInstancesResponseInstance> Instances { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComputeInstancesResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="instances">
        /// Array of compute instances belonging to the authenticated user
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
        public ListComputeInstancesResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::G.ListComputeInstancesResponseInstance> instances,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Instances = instances ?? throw new global::System.ArgumentNullException(nameof(instances));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComputeInstancesResponse" /> class.
        /// </summary>
        public ListComputeInstancesResponse()
        {
        }
    }
}