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
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_relative_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountRelativePath { get; set; }

        /// <summary>
        /// Absolute mount path inside the sandbox (e.g. /mnt/files)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_mount_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxMountPrefix { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of last modification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastModified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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