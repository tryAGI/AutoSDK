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
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FileFile File1 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"file"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "file";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="file1"></param>
        /// <param name="type"></param>
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