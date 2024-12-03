//HintName: G.Models.GetChannelStreamScheduleResponseDataPagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The information used to page through a list of results. The object is empty if there are no more pages left to page through. [Read more](https://dev.twitch.tv/docs/api/guide#pagination).
    /// </summary>
    public sealed partial class GetChannelStreamScheduleResponseDataPagination
    {
        /// <summary>
        /// The cursor used to get the next page of results. Set the request’s _after_ query parameter to this value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelStreamScheduleResponseDataPagination" /> class.
        /// </summary>
        /// <param name="cursor">
        /// The cursor used to get the next page of results. Set the request’s _after_ query parameter to this value.
        /// </param>
        public GetChannelStreamScheduleResponseDataPagination(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelStreamScheduleResponseDataPagination" /> class.
        /// </summary>
        public GetChannelStreamScheduleResponseDataPagination()
        {
        }
    }
}