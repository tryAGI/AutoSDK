//HintName: G.Models.PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest
    {
        /// <summary>
        /// Relative file path within the mount<br/>
        /// Example: report.pdf
        /// </summary>
        /// <example>report.pdf</example>
        [global::Newtonsoft.Json.JsonProperty("mount_relative_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string MountRelativePath { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest" /> class.
        /// </summary>
        /// <param name="mountRelativePath">
        /// Relative file path within the mount<br/>
        /// Example: report.pdf
        /// </param>
        public PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest(
            string mountRelativePath)
        {
            this.MountRelativePath = mountRelativePath ?? throw new global::System.ArgumentNullException(nameof(mountRelativePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest()
        {
        }
    }
}