//HintName: G.Models.LocationResultOpeningHours.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Opening hours information.
    /// </summary>
    public sealed partial class LocationResultOpeningHours
    {
        /// <summary>
        /// Opening hours for the current day.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_day")]
        public global::System.Collections.Generic.IList<global::G.LocationResultOpeningHoursCurrentDayItem>? CurrentDay { get; set; }

        /// <summary>
        /// Opening hours by day of the week.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("days")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.LocationResultOpeningHoursDay>>? Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultOpeningHours" /> class.
        /// </summary>
        /// <param name="currentDay">
        /// Opening hours for the current day.
        /// </param>
        /// <param name="days">
        /// Opening hours by day of the week.
        /// </param>
        public LocationResultOpeningHours(
            global::System.Collections.Generic.IList<global::G.LocationResultOpeningHoursCurrentDayItem>? currentDay,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.LocationResultOpeningHoursDay>>? days)
        {
            this.CurrentDay = currentDay;
            this.Days = days;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultOpeningHours" /> class.
        /// </summary>
        public LocationResultOpeningHours()
        {
        }
    }
}