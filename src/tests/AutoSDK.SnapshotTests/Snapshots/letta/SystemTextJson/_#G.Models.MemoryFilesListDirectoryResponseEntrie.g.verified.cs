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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MemoryFilesListDirectoryResponseEntrieTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MemoryFilesListDirectoryResponseEntrieType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesListDirectoryResponseEntrie" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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