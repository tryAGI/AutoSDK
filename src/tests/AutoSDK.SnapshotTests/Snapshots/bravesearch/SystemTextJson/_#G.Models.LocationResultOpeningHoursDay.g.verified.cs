//HintName: G.Models.LocationResultOpeningHoursDay.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocationResultOpeningHoursDay
    {
        /// <summary>
        /// Opening time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opens")]
        public string? Opens { get; set; }

        /// <summary>
        /// Closing time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closes")]
        public string? Closes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultOpeningHoursDay" /> class.
        /// </summary>
        /// <param name="opens">
        /// Opening time.
        /// </param>
        /// <param name="closes">
        /// Closing time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocationResultOpeningHoursDay(
            string? opens,
            string? closes)
        {
            this.Opens = opens;
            this.Closes = closes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultOpeningHoursDay" /> class.
        /// </summary>
        public LocationResultOpeningHoursDay()
        {
        }
    }
}