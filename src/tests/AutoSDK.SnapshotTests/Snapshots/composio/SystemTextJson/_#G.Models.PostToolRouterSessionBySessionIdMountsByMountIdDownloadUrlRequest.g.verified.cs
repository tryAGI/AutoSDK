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
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_relative_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountRelativePath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlRequest" /> class.
        /// </summary>
        /// <param name="mountRelativePath">
        /// Relative file path within the mount<br/>
        /// Example: report.pdf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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