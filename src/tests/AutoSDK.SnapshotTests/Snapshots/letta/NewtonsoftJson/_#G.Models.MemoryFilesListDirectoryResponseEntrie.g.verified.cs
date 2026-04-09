//HintName: G.Models.MemoryFilesListDirectoryResponseEntrie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryFilesListDirectoryResponseEntrie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MemoryFilesListDirectoryResponseEntrieTypeJsonConverter))]
        public global::G.MemoryFilesListDirectoryResponseEntrieType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesListDirectoryResponseEntrie" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public MemoryFilesListDirectoryResponseEntrie(
            string name,
            global::G.MemoryFilesListDirectoryResponseEntrieType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesListDirectoryResponseEntrie" /> class.
        /// </summary>
        public MemoryFilesListDirectoryResponseEntrie()
        {
        }
    }
}