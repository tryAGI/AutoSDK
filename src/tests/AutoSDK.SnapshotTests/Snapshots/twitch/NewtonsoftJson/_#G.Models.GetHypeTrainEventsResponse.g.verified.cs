//HintName: G.Models.GetHypeTrainEventsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetHypeTrainEventsResponse
    {
        /// <summary>
        /// The list of Hype Train events. The list is empty if the broadcaster hasn’t run a Hype Train within the last 5 days.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.HypeTrainEvent> Data { get; set; } = default!;

        /// <summary>
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public global::G.GetHypeTrainEventsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHypeTrainEventsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of Hype Train events. The list is empty if the broadcaster hasn’t run a Hype Train within the last 5 days.
        /// </param>
        /// <param name="pagination">
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
        public GetHypeTrainEventsResponse(
            global::System.Collections.Generic.IList<global::G.HypeTrainEvent> data,
            global::G.GetHypeTrainEventsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHypeTrainEventsResponse" /> class.
        /// </summary>
        public GetHypeTrainEventsResponse()
        {
        }
    }
}