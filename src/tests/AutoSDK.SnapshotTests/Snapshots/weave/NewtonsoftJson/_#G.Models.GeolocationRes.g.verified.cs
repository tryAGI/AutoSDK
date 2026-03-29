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
        [global::Newtonsoft.Json.JsonProperty("ip", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ip { get; set; } = default!;

        /// <summary>
        /// Information about the location of the IP address, None if could not be determined
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public global::G.Geolocation? Location { get; set; }

        /// <summary>
        /// Whether the IP address is allowed to be used for inference.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed")]
        public bool? Allowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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