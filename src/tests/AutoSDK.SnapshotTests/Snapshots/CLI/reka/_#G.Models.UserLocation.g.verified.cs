//HintName: G.Models.UserLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Geographic context for localized search results.
    /// </summary>
    public sealed partial class UserLocation
    {
        /// <summary>
        /// Approximate geographic location. At least one field is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approximate")]
        public global::G.ApproximateLocation? Approximate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocation" /> class.
        /// </summary>
        /// <param name="approximate">
        /// Approximate geographic location. At least one field is required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserLocation(
            global::G.ApproximateLocation? approximate)
        {
            this.Approximate = approximate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocation" /> class.
        /// </summary>
        public UserLocation()
        {
        }
    }
}