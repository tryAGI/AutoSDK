//HintName: G.Models.LocationResultOpeningHoursCurrentDayItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocationResultOpeningHoursCurrentDayItem
    {
        /// <summary>
        /// Opening time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("opens")]
        public string? Opens { get; set; }

        /// <summary>
        /// Closing time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closes")]
        public string? Closes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultOpeningHoursCurrentDayItem" /> class.
        /// </summary>
        /// <param name="opens">
        /// Opening time.
        /// </param>
        /// <param name="closes">
        /// Closing time.
        /// </param>
        public LocationResultOpeningHoursCurrentDayItem(
            string? opens,
            string? closes)
        {
            this.Opens = opens;
            this.Closes = closes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultOpeningHoursCurrentDayItem" /> class.
        /// </summary>
        public LocationResultOpeningHoursCurrentDayItem()
        {
        }
    }
}