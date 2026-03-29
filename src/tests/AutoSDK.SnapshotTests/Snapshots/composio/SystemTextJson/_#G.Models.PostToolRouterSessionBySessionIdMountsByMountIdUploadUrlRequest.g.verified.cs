//HintName: G.Models.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest
    {
        /// <summary>
        /// Supports subdirectories (e.g. "data/output.csv", "images/charts/chart.png")<br/>
        /// Example: report.pdf
        /// </summary>
        /// <example>report.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_relative_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountRelativePath { get; set; }

        /// <summary>
        /// MIME type of the file being uploaded<br/>
        /// Example: application/pdf
        /// </summary>
        /// <example>application/pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        public string? Mimetype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest" /> class.
        /// </summary>
        /// <param name="mountRelativePath">
        /// Supports subdirectories (e.g. "data/output.csv", "images/charts/chart.png")<br/>
        /// Example: report.pdf
        /// </param>
        /// <param name="mimetype">
        /// MIME type of the file being uploaded<br/>
        /// Example: application/pdf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest(
            string mountRelativePath,
            string? mimetype)
        {
            this.MountRelativePath = mountRelativePath ?? throw new global::System.ArgumentNullException(nameof(mountRelativePath));
            this.Mimetype = mimetype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest()
        {
        }
    }
}