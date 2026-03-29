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
        [global::Newtonsoft.Json.JsonProperty("upload_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadUrl { get; set; } = default!;

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
        /// ISO 8601 timestamp when the upload URL expires
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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