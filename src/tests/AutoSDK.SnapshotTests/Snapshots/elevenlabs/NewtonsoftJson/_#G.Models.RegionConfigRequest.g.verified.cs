//HintName: G.Models.RegionConfigRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegionConfigRequest
    {
        /// <summary>
        /// Region ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region_id", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TwilioRegionIdJsonConverter))]
        public global::G.TwilioRegionId RegionId { get; set; } = default!;

        /// <summary>
        /// Auth Token for this region
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Edge location for this region
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edge_location", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TwilioEdgeLocationJsonConverter))]
        public global::G.TwilioEdgeLocation EdgeLocation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionConfigRequest" /> class.
        /// </summary>
        /// <param name="regionId">
        /// Region ID
        /// </param>
        /// <param name="token">
        /// Auth Token for this region
        /// </param>
        /// <param name="edgeLocation">
        /// Edge location for this region
        /// </param>
        public RegionConfigRequest(
            global::G.TwilioRegionId regionId,
            string token,
            global::G.TwilioEdgeLocation edgeLocation)
        {
            this.RegionId = regionId;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.EdgeLocation = edgeLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionConfigRequest" /> class.
        /// </summary>
        public RegionConfigRequest()
        {
        }
    }
}