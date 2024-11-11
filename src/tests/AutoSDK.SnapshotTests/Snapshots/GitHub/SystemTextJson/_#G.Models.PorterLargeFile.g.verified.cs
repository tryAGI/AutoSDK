//HintName: G.Models.PorterLargeFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Porter Large File
    /// </summary>
    public sealed partial class PorterLargeFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Oid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PorterLargeFile" /> class.
        /// </summary>
        /// <param name="refName"></param>
        /// <param name="path"></param>
        /// <param name="oid"></param>
        /// <param name="size"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PorterLargeFile(
            string refName,
            string path,
            string oid,
            int size)
        {
            this.RefName = refName ?? throw new global::System.ArgumentNullException(nameof(refName));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Oid = oid ?? throw new global::System.ArgumentNullException(nameof(oid));
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PorterLargeFile" /> class.
        /// </summary>
        public PorterLargeFile()
        {
        }
    }
}