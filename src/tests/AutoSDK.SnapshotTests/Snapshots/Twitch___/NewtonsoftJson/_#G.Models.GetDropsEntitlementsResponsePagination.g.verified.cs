//HintName: G.Models.GetDropsEntitlementsResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
    /// </summary>
    public sealed partial class GetDropsEntitlementsResponsePagination
    {
        /// <summary>
        /// The cursor used to get the next page of results. Set the request’s _after_ query parameter to this value to page forward through the results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDropsEntitlementsResponsePagination" /> class.
        /// </summary>
        /// <param name="cursor">
        /// The cursor used to get the next page of results. Set the request’s _after_ query parameter to this value to page forward through the results.
        /// </param>
        public GetDropsEntitlementsResponsePagination(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDropsEntitlementsResponsePagination" /> class.
        /// </summary>
        public GetDropsEntitlementsResponsePagination()
        {
        }
    }
}