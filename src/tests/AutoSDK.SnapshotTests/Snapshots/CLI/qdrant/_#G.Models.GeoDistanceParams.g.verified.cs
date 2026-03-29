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
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeoPoint Origin { get; set; }

        /// <summary>
        /// Payload field with the destination geo point
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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