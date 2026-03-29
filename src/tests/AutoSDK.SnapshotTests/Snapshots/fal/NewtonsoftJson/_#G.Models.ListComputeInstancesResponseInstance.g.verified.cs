//HintName: G.Models.ListComputeInstancesResponseInstance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Compute instance details including configuration, location, and status
    /// </summary>
    public sealed partial class ListComputeInstancesResponseInstance
    {
        /// <summary>
        /// Unique identifier for the compute instance<br/>
        /// Example: inst_abc123xyz
        /// </summary>
        /// <example>inst_abc123xyz</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Type of compute instance (GPU configuration)<br/>
        /// Example: gpu_1x_h100_sxm5
        /// </summary>
        /// <example>gpu_1x_h100_sxm5</example>
        [global::Newtonsoft.Json.JsonProperty("instance_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListComputeInstancesResponseInstanceInstanceType InstanceType { get; set; } = default!;

        /// <summary>
        /// Geographical region where the instance is located<br/>
        /// Example: us-west
        /// </summary>
        /// <example>us-west</example>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListComputeInstancesResponseInstanceRegion Region { get; set; } = default!;

        /// <summary>
        /// Sector identifier for instance placement within the region (if applicable)<br/>
        /// Example: sector_1
        /// </summary>
        /// <example>sector_1</example>
        [global::Newtonsoft.Json.JsonProperty("sector")]
        public global::G.ListComputeInstancesResponseInstanceSector? Sector { get; set; }

        /// <summary>
        /// IP address of the instance (available when instance is ready)<br/>
        /// Example: 203.0.113.42
        /// </summary>
        /// <example>203.0.113.42</example>
        [global::Newtonsoft.Json.JsonProperty("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// Current operational status of the instance<br/>
        /// Example: ready
        /// </summary>
        /// <example>ready</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListComputeInstancesResponseInstanceStatus Status { get; set; } = default!;

        /// <summary>
        /// Nickname of the user who created this instance<br/>
        /// Example: developer
        /// </summary>
        /// <example>developer</example>
        [global::Newtonsoft.Json.JsonProperty("creator_user_nickname")]
        public string? CreatorUserNickname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComputeInstancesResponseInstance" /> class.
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
        public ListComputeInstancesResponseInstance(
            string id,
            global::G.ListComputeInstancesResponseInstanceInstanceType instanceType,
            global::G.ListComputeInstancesResponseInstanceRegion region,
            global::G.ListComputeInstancesResponseInstanceStatus status,
            global::G.ListComputeInstancesResponseInstanceSector? sector,
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
        /// Initializes a new instance of the <see cref="ListComputeInstancesResponseInstance" /> class.
        /// </summary>
        public ListComputeInstancesResponseInstance()
        {
        }
    }
}