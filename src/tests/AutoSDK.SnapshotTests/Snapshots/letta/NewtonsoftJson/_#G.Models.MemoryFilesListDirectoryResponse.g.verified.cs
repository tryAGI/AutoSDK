//HintName: G.Models.MemoryFilesListDirectoryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryFilesListDirectoryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MemoryFilesListDirectoryResponseEntrie> Entries { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("depth", Required = global::Newtonsoft.Json.Required.Always)]
        public double Depth { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesListDirectoryResponse" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="entries"></param>
        /// <param name="depth"></param>
        public MemoryFilesListDirectoryResponse(
            string path,
            global::System.Collections.Generic.IList<global::G.MemoryFilesListDirectoryResponseEntrie> entries,
            double depth)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
            this.Depth = depth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesListDirectoryResponse" /> class.
        /// </summary>
        public MemoryFilesListDirectoryResponse()
        {
        }
    }
}