//HintName: G.Models.CallTimeWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allowed calling windows in a specific timezone. Each window is a half-open interval [startMin, endMin) in minutes since 00:00 local time. Cross-midnight windows are NOT allowed (must satisfy startMin &lt; endMin). `endMin = 1440` (24:00) is valid.
    /// </summary>
    public sealed partial class CallTimeWindow
    {
        /// <summary>
        /// List of TimeWindow (start/end in minutes since local midnight).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TimeWindow> Windows { get; set; } = default!;

        /// <summary>
        /// IANA timezone (e.g. America/Los_Angeles). Defaults to America/Los_Angeles if omitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Optional list of days to which the windows apply. If omitted or empty, windows apply to every day.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("day")]
        public global::System.Collections.Generic.IList<global::G.DayOfWeek>? Day { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallTimeWindow" /> class.
        /// </summary>
        /// <param name="windows">
        /// List of TimeWindow (start/end in minutes since local midnight).
        /// </param>
        /// <param name="timezone">
        /// IANA timezone (e.g. America/Los_Angeles). Defaults to America/Los_Angeles if omitted.
        /// </param>
        /// <param name="day">
        /// Optional list of days to which the windows apply. If omitted or empty, windows apply to every day.
        /// </param>
        public CallTimeWindow(
            global::System.Collections.Generic.IList<global::G.TimeWindow> windows,
            string? timezone,
            global::System.Collections.Generic.IList<global::G.DayOfWeek>? day)
        {
            this.Windows = windows ?? throw new global::System.ArgumentNullException(nameof(windows));
            this.Timezone = timezone;
            this.Day = day;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallTimeWindow" /> class.
        /// </summary>
        public CallTimeWindow()
        {
        }
    }
}