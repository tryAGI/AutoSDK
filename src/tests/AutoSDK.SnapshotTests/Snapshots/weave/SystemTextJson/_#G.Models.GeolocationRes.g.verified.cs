//HintName: G.Models.GeolocationRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeolocationRes
    {
        /// <summary>
        /// Resolved IP address, useful for debugging
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ip { get; set; }

        /// <summary>
        /// Information about the location of the IP address, None if could not be determined
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::G.Geolocation? Location { get; set; }

        /// <summary>
        /// Whether the IP address is allowed to be used for inference.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed")]
        public bool? Allowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationRes" /> class.
        /// </summary>
        /// <param name="ip">
        /// Resolved IP address, useful for debugging
        /// </param>
        /// <param name="location">
        /// Information about the location of the IP address, None if could not be determined
        /// </param>
        /// <param name="allowed">
        /// Whether the IP address is allowed to be used for inference.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeolocationRes(
            string ip,
            global::G.Geolocation? location,
            bool? allowed)
        {
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.Location = location;
            this.Allowed = allowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeolocationRes" /> class.
        /// </summary>
        public GeolocationRes()
        {
        }
    }
}