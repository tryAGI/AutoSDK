//HintName: G.Models.PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse
    {
        /// <summary>
        /// Relative file path that was deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mount_relative_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string MountRelativePath { get; set; } = default!;

        /// <summary>
        /// Absolute mount path inside the sandbox (e.g. /mnt/files)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandbox_mount_prefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string SandboxMountPrefix { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse" /> class.
        /// </summary>
        /// <param name="mountRelativePath">
        /// Relative file path that was deleted
        /// </param>
        /// <param name="sandboxMountPrefix">
        /// Absolute mount path inside the sandbox (e.g. /mnt/files)
        /// </param>
        public PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse(
            string mountRelativePath,
            string sandboxMountPrefix)
        {
            this.MountRelativePath = mountRelativePath ?? throw new global::System.ArgumentNullException(nameof(mountRelativePath));
            this.SandboxMountPrefix = sandboxMountPrefix ?? throw new global::System.ArgumentNullException(nameof(sandboxMountPrefix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse()
        {
        }
    }
}