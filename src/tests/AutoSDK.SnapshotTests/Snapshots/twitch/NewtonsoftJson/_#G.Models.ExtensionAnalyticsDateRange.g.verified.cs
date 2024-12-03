//HintName: G.Models.ExtensionAnalyticsDateRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reporting window’s start and end dates, in RFC3339 format.
    /// </summary>
    public sealed partial class ExtensionAnalyticsDateRange
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
        /// Initializes a new instance of the <see cref="ExtensionAnalyticsDateRange" /> class.
        /// </summary>
        /// <param name="startedAt">
        /// The reporting window’s start date.
        /// </param>
        /// <param name="endedAt">
        /// The reporting window’s end date.
        /// </param>
        public ExtensionAnalyticsDateRange(
            global::System.DateTime startedAt,
            global::System.DateTime endedAt)
        {
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionAnalyticsDateRange" /> class.
        /// </summary>
        public ExtensionAnalyticsDateRange()
        {
        }
    }
}