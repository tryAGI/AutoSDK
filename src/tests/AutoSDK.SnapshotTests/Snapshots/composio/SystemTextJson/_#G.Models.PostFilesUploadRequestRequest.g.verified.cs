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
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolkitSlug { get; set; }

        /// <summary>
        /// Slug of the action where this file belongs to. Example: "GMAIL_SEND_EMAIL", "SLACK_UPLOAD_FILE"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolSlug { get; set; }

        /// <summary>
        /// Name of the original file. Example: "quarterly_report.pdf"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Mime type of the original file. Example: "application/pdf", "image/png"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mimetype { get; set; }

        /// <summary>
        /// MD5 hash of the file for deduplication and integrity verification. Example: "a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md5")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Md5 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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