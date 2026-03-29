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
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MemoryFilesListDirectoryResponseEntrie> Entries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Depth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesListDirectoryResponse" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="entries"></param>
        /// <param name="depth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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