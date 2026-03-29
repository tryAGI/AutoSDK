//HintName: G.Models.GeoDistanceParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeoDistanceParams
    {
        /// <summary>
        /// Geo point payload schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeoPoint Origin { get; set; } = default!;

        /// <summary>
        /// Payload field with the destination geo point
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public string To { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoDistanceParams" /> class.
        /// </summary>
        /// <param name="origin">
        /// Geo point payload schema
        /// </param>
        /// <param name="to">
        /// Payload field with the destination geo point
        /// </param>
        public GeoDistanceParams(
            global::G.GeoPoint origin,
            string to)
        {
            this.Origin = origin ?? throw new global::System.ArgumentNullException(nameof(origin));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoDistanceParams" /> class.
        /// </summary>
        public GeoDistanceParams()
        {
        }
    }
}