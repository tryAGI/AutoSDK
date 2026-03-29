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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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