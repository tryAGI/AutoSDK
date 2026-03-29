//HintName: G.Models.ApplicationInputFileOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options specific to file upload input fields.
    /// </summary>
    public sealed partial class ApplicationInputFileOptions
    {
        /// <summary>
        /// Maximum number of files that can be uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxFiles { get; set; }

        /// <summary>
        /// List of allowed file extensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FileTypes { get; set; }

        /// <summary>
        /// Maximum number of words allowed in text files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_word_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxWordCount { get; set; }

        /// <summary>
        /// Maximum file size allowed in megabytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_file_size_mb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxFileSizeMb { get; set; }

        /// <summary>
        /// List of allowed upload types for file inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FileUploadType> UploadTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputFileOptions" /> class.
        /// </summary>
        /// <param name="maxFiles">
        /// Maximum number of files that can be uploaded.
        /// </param>
        /// <param name="fileTypes">
        /// List of allowed file extensions.
        /// </param>
        /// <param name="maxWordCount">
        /// Maximum number of words allowed in text files.
        /// </param>
        /// <param name="maxFileSizeMb">
        /// Maximum file size allowed in megabytes.
        /// </param>
        /// <param name="uploadTypes">
        /// List of allowed upload types for file inputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplicationInputFileOptions(
            int maxFiles,
            global::System.Collections.Generic.IList<string> fileTypes,
            int maxWordCount,
            int maxFileSizeMb,
            global::System.Collections.Generic.IList<global::G.FileUploadType> uploadTypes)
        {
            this.MaxFiles = maxFiles;
            this.FileTypes = fileTypes ?? throw new global::System.ArgumentNullException(nameof(fileTypes));
            this.MaxWordCount = maxWordCount;
            this.MaxFileSizeMb = maxFileSizeMb;
            this.UploadTypes = uploadTypes ?? throw new global::System.ArgumentNullException(nameof(uploadTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputFileOptions" /> class.
        /// </summary>
        public ApplicationInputFileOptions()
        {
        }
    }
}