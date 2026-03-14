//HintName: G.Models.IntervalScheduleConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for interval-based schedule execution.
    /// </summary>
    public sealed partial class IntervalScheduleConfiguration
    {
        /// <summary>
        /// The type of schedule.<br/>
        /// Example: interval
        /// </summary>
        /// <example>interval</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IntervalScheduleConfigurationTypeJsonConverter))]
        public global::G.IntervalScheduleConfigurationType Type { get; set; }

        /// <summary>
        /// ISO-8601 duration string specifying the interval between executions.<br/>
        /// Minimum interval is 1 minute (PT1M).<br/>
        /// Format: P[n]Y[n]M[n]DT[n]H[n]M[n]S<br/>
        /// - P: Period designator (required)<br/>
        /// - T: Time designator (separates date and time components)<br/>
        /// Common examples:<br/>
        /// - PT1M: Every 1 minute<br/>
        /// - PT1H: Every 1 hour<br/>
        /// - PT6H: Every 6 hours<br/>
        /// - PT24H or P1D: Every 24 hours (daily)<br/>
        /// - P7D: Every 7 days (weekly)<br/>
        /// - P1M: Every 1 month<br/>
        /// Reference: https://en.wikipedia.org/wiki/ISO_8601#Durations<br/>
        /// Example: PT24H
        /// </summary>
        /// <example>PT24H</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Interval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalScheduleConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of schedule.<br/>
        /// Example: interval
        /// </param>
        /// <param name="interval">
        /// ISO-8601 duration string specifying the interval between executions.<br/>
        /// Minimum interval is 1 minute (PT1M).<br/>
        /// Format: P[n]Y[n]M[n]DT[n]H[n]M[n]S<br/>
        /// - P: Period designator (required)<br/>
        /// - T: Time designator (separates date and time components)<br/>
        /// Common examples:<br/>
        /// - PT1M: Every 1 minute<br/>
        /// - PT1H: Every 1 hour<br/>
        /// - PT6H: Every 6 hours<br/>
        /// - PT24H or P1D: Every 24 hours (daily)<br/>
        /// - P7D: Every 7 days (weekly)<br/>
        /// - P1M: Every 1 month<br/>
        /// Reference: https://en.wikipedia.org/wiki/ISO_8601#Durations<br/>
        /// Example: PT24H
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntervalScheduleConfiguration(
            string interval,
            global::G.IntervalScheduleConfigurationType type)
        {
            this.Interval = interval ?? throw new global::System.ArgumentNullException(nameof(interval));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalScheduleConfiguration" /> class.
        /// </summary>
        public IntervalScheduleConfiguration()
        {
        }
    }
}