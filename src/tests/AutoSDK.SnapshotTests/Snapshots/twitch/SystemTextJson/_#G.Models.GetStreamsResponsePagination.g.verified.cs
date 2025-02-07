//HintName: G.Models.GetStreamsResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
    /// </summary>
    public sealed partial class GetStreamsResponsePagination
    {
        /// <summary>
        /// The cursor used to get the next page of results. Set the request’s _after_ or _before_ query parameter to this value depending on whether you’re paging forwards or backwards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamsResponsePagination" /> class.
        /// </summary>
        /// <param name="cursor">
        /// The cursor used to get the next page of results. Set the request’s _after_ or _before_ query parameter to this value depending on whether you’re paging forwards or backwards.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStreamsResponsePagination(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamsResponsePagination" /> class.
        /// </summary>
        public GetStreamsResponsePagination()
        {
        }
    }
}