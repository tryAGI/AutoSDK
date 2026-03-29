//HintName: G.Models.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse
    {
        /// <summary>
        /// Presigned upload URL — PUT the file content here
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

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
        /// ISO 8601 timestamp when the upload URL expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse" /> class.
        /// </summary>
        /// <param name="uploadUrl">
        /// Presigned upload URL — PUT the file content here
        /// </param>
        /// <param name="mountRelativePath">
        /// Relative file path within the mount (e.g. "report.pdf")
        /// </param>
        /// <param name="sandboxMountPrefix">
        /// Absolute mount path inside the sandbox (e.g. /mnt/files)
        /// </param>
        /// <param name="expiresAt">
        /// ISO 8601 timestamp when the upload URL expires
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse(
            string uploadUrl,
            string mountRelativePath,
            string sandboxMountPrefix,
            string expiresAt)
        {
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.MountRelativePath = mountRelativePath ?? throw new global::System.ArgumentNullException(nameof(mountRelativePath));
            this.SandboxMountPrefix = sandboxMountPrefix ?? throw new global::System.ArgumentNullException(nameof(sandboxMountPrefix));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse()
        {
        }
    }
}