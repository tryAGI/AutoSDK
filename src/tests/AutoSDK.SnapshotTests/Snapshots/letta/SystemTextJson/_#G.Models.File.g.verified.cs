//HintName: G.Models.File.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Learn about [file inputs](https://platform.openai.com/docs/guides/text) for text generation.
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FileFile File1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"file"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "file";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="file1"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public File(
            global::G.FileFile file1,
            string type = "file")
        {
            this.File1 = file1 ?? throw new global::System.ArgumentNullException(nameof(file1));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}