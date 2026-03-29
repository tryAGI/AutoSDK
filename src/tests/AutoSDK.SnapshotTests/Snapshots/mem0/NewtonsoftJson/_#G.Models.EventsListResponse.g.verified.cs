//HintName: G.Models.EventsListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventsListResponse
    {
        /// <summary>
        /// Total number of events matching the filters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// URL for the next page of results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next")]
        public string? Next { get; set; }

        /// <summary>
        /// URL for the previous page of results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// Array of event objects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EventsListResponseResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsListResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// Total number of events matching the filters.
        /// </param>
        /// <param name="results">
        /// Array of event objects.
        /// </param>
        /// <param name="next">
        /// URL for the next page of results.
        /// </param>
        /// <param name="previous">
        /// URL for the previous page of results.
        /// </param>
        public EventsListResponse(
            int count,
            global::System.Collections.Generic.IList<global::G.EventsListResponseResult> results,
            string? next,
            string? previous)
        {
            this.Count = count;
            this.Next = next;
            this.Previous = previous;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsListResponse" /> class.
        /// </summary>
        public EventsListResponse()
        {
        }
    }
}