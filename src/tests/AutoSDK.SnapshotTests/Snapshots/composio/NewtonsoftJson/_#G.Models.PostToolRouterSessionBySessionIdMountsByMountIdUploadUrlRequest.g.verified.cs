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
        [global::Newtonsoft.Json.JsonProperty("mount_relative_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string MountRelativePath { get; set; } = default!;

        /// <summary>
        /// MIME type of the file being uploaded<br/>
        /// Example: application/pdf
        /// </summary>
        /// <example>application/pdf</example>
        [global::Newtonsoft.Json.JsonProperty("mimetype")]
        public string? Mimetype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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