//HintName: G.Models.RunOutputFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class RunOutputFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunOutputFile" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="url"></param>
        /// <param name="size"></param>
        public RunOutputFile(
            string name,
            string path,
            int size,
            string? url)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Size = size;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunOutputFile" /> class.
        /// </summary>
        public RunOutputFile()
        {
        }
    }
}