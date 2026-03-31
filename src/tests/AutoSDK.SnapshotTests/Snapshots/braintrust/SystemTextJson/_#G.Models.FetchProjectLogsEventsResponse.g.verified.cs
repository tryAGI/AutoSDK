//HintName: G.Models.FetchProjectLogsEventsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FetchProjectLogsEventsResponse
    {
        /// <summary>
        /// A list of fetched events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ProjectLogsEvent> Events { get; set; }

        /// <summary>
        /// Pagination cursor<br/>
        /// Pass this string directly as the `cursor` param to your next fetch request to get the next page of results. Not provided if the returned result set is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchProjectLogsEventsResponse" /> class.
        /// </summary>
        /// <param name="events">
        /// A list of fetched events
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor<br/>
        /// Pass this string directly as the `cursor` param to your next fetch request to get the next page of results. Not provided if the returned result set is empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchProjectLogsEventsResponse(
            global::System.Collections.Generic.IList<global::G.ProjectLogsEvent> events,
            string? cursor)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchProjectLogsEventsResponse" /> class.
        /// </summary>
        public FetchProjectLogsEventsResponse()
        {
        }
    }
}