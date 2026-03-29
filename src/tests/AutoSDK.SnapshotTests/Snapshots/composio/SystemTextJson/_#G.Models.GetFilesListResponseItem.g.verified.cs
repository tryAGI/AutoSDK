//HintName: G.Models.GetFilesListResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFilesListResponseItem
    {
        /// <summary>
        /// Slug of the app where this file belongs to. Example: "file-converter"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolkitSlug { get; set; }

        /// <summary>
        /// Slug of the action where this file belongs to. Example: "convert-to-pdf"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolSlug { get; set; }

        /// <summary>
        /// Name of the original file. Example: "document.docx"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Mime type of the original file. Example: "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mimetype { get; set; }

        /// <summary>
        /// MD5 hash of the file for integrity verification. Example: "d41d8cd98f00b204e9800998ecf8427e"
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
        /// Initializes a new instance of the <see cref="GetFilesListResponseItem" /> class.
        /// </summary>
        /// <param name="toolkitSlug">
        /// Slug of the app where this file belongs to. Example: "file-converter"
        /// </param>
        /// <param name="toolSlug">
        /// Slug of the action where this file belongs to. Example: "convert-to-pdf"
        /// </param>
        /// <param name="filename">
        /// Name of the original file. Example: "document.docx"
        /// </param>
        /// <param name="mimetype">
        /// Mime type of the original file. Example: "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
        /// </param>
        /// <param name="md5">
        /// MD5 hash of the file for integrity verification. Example: "d41d8cd98f00b204e9800998ecf8427e"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFilesListResponseItem(
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
        /// Initializes a new instance of the <see cref="GetFilesListResponseItem" /> class.
        /// </summary>
        public GetFilesListResponseItem()
        {
        }
    }
}