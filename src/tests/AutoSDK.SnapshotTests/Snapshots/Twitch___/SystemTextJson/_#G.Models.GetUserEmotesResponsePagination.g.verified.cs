//HintName: G.Models.GetUserEmotesResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.   <br/>
    ///   <br/>
    ///  For more information about pagination support, see [Twitch API Guide - Pagination](https://dev.twitch.tv/docs/api/guide#pagination).
    /// </summary>
    public sealed partial class GetUserEmotesResponsePagination
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
        /// Initializes a new instance of the <see cref="GetUserEmotesResponsePagination" /> class.
        /// </summary>
        /// <param name="cursor">
        /// The cursor used to get the next page of results. Use the cursor to set the request’s after query parameter.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetUserEmotesResponsePagination(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserEmotesResponsePagination" /> class.
        /// </summary>
        public GetUserEmotesResponsePagination()
        {
        }
    }
}