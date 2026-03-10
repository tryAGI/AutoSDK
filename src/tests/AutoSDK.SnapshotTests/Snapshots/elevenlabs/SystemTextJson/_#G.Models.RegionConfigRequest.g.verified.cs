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
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TwilioRegionIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TwilioRegionId RegionId { get; set; }

        /// <summary>
        /// Auth Token for this region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Edge location for this region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TwilioEdgeLocationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TwilioEdgeLocation EdgeLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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