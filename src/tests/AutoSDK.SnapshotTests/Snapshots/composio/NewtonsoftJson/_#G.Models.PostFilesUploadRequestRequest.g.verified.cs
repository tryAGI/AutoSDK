//HintName: G.Models.PostFilesUploadRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostFilesUploadRequestRequest
    {
        /// <summary>
        /// Slug of the app where this file belongs to. Example: "gmail", "slack", "github"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkit_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolkitSlug { get; set; } = default!;

        /// <summary>
        /// Slug of the action where this file belongs to. Example: "GMAIL_SEND_EMAIL", "SLACK_UPLOAD_FILE"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolSlug { get; set; } = default!;

        /// <summary>
        /// Name of the original file. Example: "quarterly_report.pdf"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Mime type of the original file. Example: "application/pdf", "image/png"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimetype", Required = global::Newtonsoft.Json.Required.Always)]
        public string Mimetype { get; set; } = default!;

        /// <summary>
        /// MD5 hash of the file for deduplication and integrity verification. Example: "a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("md5", Required = global::Newtonsoft.Json.Required.Always)]
        public string Md5 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFilesUploadRequestRequest" /> class.
        /// </summary>
        /// <param name="toolkitSlug">
        /// Slug of the app where this file belongs to. Example: "gmail", "slack", "github"
        /// </param>
        /// <param name="toolSlug">
        /// Slug of the action where this file belongs to. Example: "GMAIL_SEND_EMAIL", "SLACK_UPLOAD_FILE"
        /// </param>
        /// <param name="filename">
        /// Name of the original file. Example: "quarterly_report.pdf"
        /// </param>
        /// <param name="mimetype">
        /// Mime type of the original file. Example: "application/pdf", "image/png"
        /// </param>
        /// <param name="md5">
        /// MD5 hash of the file for deduplication and integrity verification. Example: "a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6"
        /// </param>
        public PostFilesUploadRequestRequest(
            string toolkitSlug,
            string toolSlug,
            string filename,
            string mimetype,
            string md5)
        {
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.ToolSlug = toolSlug ?? throw new global::System.ArgumentNullException(nameof(toolSlug));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Mimetype = mimetype ?? throw new global::System.ArgumentNullException(nameof(mimetype));
            this.Md5 = md5 ?? throw new global::System.ArgumentNullException(nameof(md5));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFilesUploadRequestRequest" /> class.
        /// </summary>
        public PostFilesUploadRequestRequest()
        {
        }
    }
}