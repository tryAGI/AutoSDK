//HintName: G.Models.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem
    {
        /// <summary>
        /// Relative file path within the mount (e.g. "report.pdf")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mount_relative_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string MountRelativePath { get; set; } = default!;

        /// <summary>
        /// Absolute mount path inside the sandbox (e.g. /mnt/files)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandbox_mount_prefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string SandboxMountPrefix { get; set; } = default!;

        /// <summary>
        /// File size in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public double Size { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp of last modification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_modified", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastModified { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem" /> class.
        /// </summary>
        /// <param name="mountRelativePath">
        /// Relative file path within the mount (e.g. "report.pdf")
        /// </param>
        /// <param name="sandboxMountPrefix">
        /// Absolute mount path inside the sandbox (e.g. /mnt/files)
        /// </param>
        /// <param name="size">
        /// File size in bytes
        /// </param>
        /// <param name="lastModified">
        /// ISO 8601 timestamp of last modification
        /// </param>
        public GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem(
            string mountRelativePath,
            string sandboxMountPrefix,
            double size,
            string lastModified)
        {
            this.MountRelativePath = mountRelativePath ?? throw new global::System.ArgumentNullException(nameof(mountRelativePath));
            this.SandboxMountPrefix = sandboxMountPrefix ?? throw new global::System.ArgumentNullException(nameof(sandboxMountPrefix));
            this.Size = size;
            this.LastModified = lastModified ?? throw new global::System.ArgumentNullException(nameof(lastModified));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem()
        {
        }
    }
}