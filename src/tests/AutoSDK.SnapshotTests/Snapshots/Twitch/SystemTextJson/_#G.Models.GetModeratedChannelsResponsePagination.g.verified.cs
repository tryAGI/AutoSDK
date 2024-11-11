//HintName: G.Models.GetModeratedChannelsResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.
    /// </summary>
    public sealed partial class GetModeratedChannelsResponsePagination
    {
        /// <summary>
        /// The cursor used to get the next page of results. Use the cursor to set the request’s after query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModeratedChannelsResponsePagination" /> class.
        /// </summary>
        /// <param name="cursor">
        /// The cursor used to get the next page of results. Use the cursor to set the request’s after query parameter.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetModeratedChannelsResponsePagination(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModeratedChannelsResponsePagination" /> class.
        /// </summary>
        public GetModeratedChannelsResponsePagination()
        {
        }
    }
}