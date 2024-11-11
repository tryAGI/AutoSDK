//HintName: G.Models.TimedeltaInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timedelta input.
    /// </summary>
    public sealed partial class TimedeltaInput
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("days")]
        public int? Days { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minutes")]
        public int? Minutes { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hours")]
        public int? Hours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimedeltaInput" /> class.
        /// </summary>
        /// <param name="days">
        /// Default Value: 0
        /// </param>
        /// <param name="minutes">
        /// Default Value: 0
        /// </param>
        /// <param name="hours">
        /// Default Value: 0
        /// </param>
        public TimedeltaInput(
            int? days,
            int? minutes,
            int? hours)
        {
            this.Days = days;
            this.Minutes = minutes;
            this.Hours = hours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimedeltaInput" /> class.
        /// </summary>
        public TimedeltaInput()
        {
        }
    }
}