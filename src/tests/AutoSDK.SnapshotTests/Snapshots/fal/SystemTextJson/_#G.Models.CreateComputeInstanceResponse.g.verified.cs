//HintName: G.Models.CreateComputeInstanceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Compute instance details including configuration, location, and status
    /// </summary>
    public sealed partial class CreateComputeInstanceResponse
    {
        /// <summary>
        /// Unique identifier for the compute instance<br/>
        /// Example: inst_abc123xyz
        /// </summary>
        /// <example>inst_abc123xyz</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type of compute instance (GPU configuration)<br/>
        /// Example: gpu_1x_h100_sxm5
        /// </summary>
        /// <example>gpu_1x_h100_sxm5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateComputeInstanceResponseInstanceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateComputeInstanceResponseInstanceType InstanceType { get; set; }

        /// <summary>
        /// Geographical region where the instance is located<br/>
        /// Example: us-west
        /// </summary>
        /// <example>us-west</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateComputeInstanceResponseRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateComputeInstanceResponseRegion Region { get; set; }

        /// <summary>
        /// Sector identifier for instance placement within the region (if applicable)<br/>
        /// Example: sector_1
        /// </summary>
        /// <example>sector_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateComputeInstanceResponseSectorJsonConverter))]
        public global::G.CreateComputeInstanceResponseSector? Sector { get; set; }

        /// <summary>
        /// IP address of the instance (available when instance is ready)<br/>
        /// Example: 203.0.113.42
        /// </summary>
        /// <example>203.0.113.42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// Current operational status of the instance<br/>
        /// Example: ready
        /// </summary>
        /// <example>ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateComputeInstanceResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateComputeInstanceResponseStatus Status { get; set; }

        /// <summary>
        /// Nickname of the user who created this instance<br/>
        /// Example: developer
        /// </summary>
        /// <example>developer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_user_nickname")]
        public string? CreatorUserNickname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComputeInstanceResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the compute instance<br/>
        /// Example: inst_abc123xyz
        /// </param>
        /// <param name="instanceType">
        /// Type of compute instance (GPU configuration)<br/>
        /// Example: gpu_1x_h100_sxm5
        /// </param>
        /// <param name="region">
        /// Geographical region where the instance is located<br/>
        /// Example: us-west
        /// </param>
        /// <param name="status">
        /// Current operational status of the instance<br/>
        /// Example: ready
        /// </param>
        /// <param name="sector">
        /// Sector identifier for instance placement within the region (if applicable)<br/>
        /// Example: sector_1
        /// </param>
        /// <param name="ip">
        /// IP address of the instance (available when instance is ready)<br/>
        /// Example: 203.0.113.42
        /// </param>
        /// <param name="creatorUserNickname">
        /// Nickname of the user who created this instance<br/>
        /// Example: developer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateComputeInstanceResponse(
            string id,
            global::G.CreateComputeInstanceResponseInstanceType instanceType,
            global::G.CreateComputeInstanceResponseRegion region,
            global::G.CreateComputeInstanceResponseStatus status,
            global::G.CreateComputeInstanceResponseSector? sector,
            string? ip,
            string? creatorUserNickname)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InstanceType = instanceType;
            this.Region = region;
            this.Sector = sector;
            this.Ip = ip;
            this.Status = status;
            this.CreatorUserNickname = creatorUserNickname;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComputeInstanceResponse" /> class.
        /// </summary>
        public CreateComputeInstanceResponse()
        {
        }
    }
}