//HintName: G.Models.ApproximateLocation.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApproximateLocation
    {
        /// <summary>
        /// The type of location approximation. Always `approximate`.<br/>
        /// Default Value: approximate
        /// </summary>
        /// <default>global::G.ApproximateLocationType.Approximate</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ApproximateLocationType Type { get; set; } = global::G.ApproximateLocationType.Approximate;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public global::G.AnyOf<string, object>? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public global::G.AnyOf<string, object>? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city")]
        public global::G.AnyOf<string, object>? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public global::G.AnyOf<string, object>? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproximateLocation" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of location approximation. Always `approximate`.<br/>
        /// Default Value: approximate
        /// </param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <param name="city"></param>
        /// <param name="timezone"></param>
        public ApproximateLocation(
            global::G.AnyOf<string, object>? country,
            global::G.AnyOf<string, object>? region,
            global::G.AnyOf<string, object>? city,
            global::G.AnyOf<string, object>? timezone,
            global::G.ApproximateLocationType type = global::G.ApproximateLocationType.Approximate)
        {
            this.Type = type;
            this.Country = country;
            this.Region = region;
            this.City = city;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproximateLocation" /> class.
        /// </summary>
        public ApproximateLocation()
        {
        }
    }
}