//HintName: G.Models.FileAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileAnnotation
    {
        /// <summary>
        /// Example: path/to/file
        /// </summary>
        /// <example>path/to/file</example>
        [global::Newtonsoft.Json.JsonProperty("filePath")]
        public string? FilePath { get; set; }

        /// <summary>
        /// Example: file.txt
        /// </summary>
        /// <example>file.txt</example>
        [global::Newtonsoft.Json.JsonProperty("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnnotation" /> class.
        /// </summary>
        /// <param name="filePath">
        /// Example: path/to/file
        /// </param>
        /// <param name="fileName">
        /// Example: file.txt
        /// </param>
        public FileAnnotation(
            string? filePath,
            string? fileName)
        {
            this.FilePath = filePath;
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnnotation" /> class.
        /// </summary>
        public FileAnnotation()
        {
        }
    }
}