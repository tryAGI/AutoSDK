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
        [global::Newtonsoft.Json.JsonProperty("max_files", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxFiles { get; set; } = default!;

        /// <summary>
        /// List of allowed file extensions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_types", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> FileTypes { get; set; } = default!;

        /// <summary>
        /// Maximum number of words allowed in text files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_word_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxWordCount { get; set; } = default!;

        /// <summary>
        /// Maximum file size allowed in megabytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_file_size_mb", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxFileSizeMb { get; set; } = default!;

        /// <summary>
        /// List of allowed upload types for file inputs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_types", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FileUploadType> UploadTypes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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