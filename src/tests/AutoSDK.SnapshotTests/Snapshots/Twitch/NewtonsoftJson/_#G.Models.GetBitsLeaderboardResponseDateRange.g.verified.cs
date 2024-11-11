//HintName: G.Models.GetBitsLeaderboardResponseDateRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reporting window’s start and end dates, in RFC3339 format. The dates are calculated by using the _started\_at_ and _period_ query parameters. If you don’t specify the _started\_at_ query parameter, the fields contain empty strings.
    /// </summary>
    public sealed partial class GetBitsLeaderboardResponseDateRange
    {
        /// <summary>
        /// The reporting window’s start date.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// The reporting window’s end date.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBitsLeaderboardResponseDateRange" /> class.
        /// </summary>
        /// <param name="startedAt">
        /// The reporting window’s start date.
        /// </param>
        /// <param name="endedAt">
        /// The reporting window’s end date.
        /// </param>
        public GetBitsLeaderboardResponseDateRange(
            global::System.DateTime startedAt,
            global::System.DateTime endedAt)
        {
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBitsLeaderboardResponseDateRange" /> class.
        /// </summary>
        public GetBitsLeaderboardResponseDateRange()
        {
        }
    }
}