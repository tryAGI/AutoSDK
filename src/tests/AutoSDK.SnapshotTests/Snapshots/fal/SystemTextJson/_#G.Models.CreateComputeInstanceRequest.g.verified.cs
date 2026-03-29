//HintName: G.Models.CreateComputeInstanceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for creating a new compute instance with SSH access
    /// </summary>
    public sealed partial class CreateComputeInstanceRequest
    {
        /// <summary>
        /// Type of compute instance to create<br/>
        /// Example: gpu_1x_h100_sxm5
        /// </summary>
        /// <example>gpu_1x_h100_sxm5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateComputeInstanceRequestInstanceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateComputeInstanceRequestInstanceType InstanceType { get; set; }

        /// <summary>
        /// SSH public key for accessing the instance (e.g., 'ssh-rsa AAAAB3...')<br/>
        /// Example: ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABgQC... user@host
        /// </summary>
        /// <example>ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABgQC... user@host</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SshKey { get; set; }

        /// <summary>
        /// Sector for InfiniBand configuration (only valid with gpu_8x_h100_sxm5)<br/>
        /// Example: sector_1
        /// </summary>
        /// <example>sector_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateComputeInstanceRequestSectorJsonConverter))]
        public global::G.CreateComputeInstanceRequestSector? Sector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComputeInstanceRequest" /> class.
        /// </summary>
        /// <param name="instanceType">
        /// Type of compute instance to create<br/>
        /// Example: gpu_1x_h100_sxm5
        /// </param>
        /// <param name="sshKey">
        /// SSH public key for accessing the instance (e.g., 'ssh-rsa AAAAB3...')<br/>
        /// Example: ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABgQC... user@host
        /// </param>
        /// <param name="sector">
        /// Sector for InfiniBand configuration (only valid with gpu_8x_h100_sxm5)<br/>
        /// Example: sector_1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateComputeInstanceRequest(
            global::G.CreateComputeInstanceRequestInstanceType instanceType,
            string sshKey,
            global::G.CreateComputeInstanceRequestSector? sector)
        {
            this.InstanceType = instanceType;
            this.SshKey = sshKey ?? throw new global::System.ArgumentNullException(nameof(sshKey));
            this.Sector = sector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComputeInstanceRequest" /> class.
        /// </summary>
        public CreateComputeInstanceRequest()
        {
        }
    }
}