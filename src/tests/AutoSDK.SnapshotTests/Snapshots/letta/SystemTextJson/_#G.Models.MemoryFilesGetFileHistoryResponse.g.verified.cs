//HintName: G.Models.MemoryFilesGetFileHistoryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryFilesGetFileHistoryResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MemoryFilesGetFileHistoryResponseCommit> Commits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesGetFileHistoryResponse" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="commits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoryFilesGetFileHistoryResponse(
            string path,
            global::System.Collections.Generic.IList<global::G.MemoryFilesGetFileHistoryResponseCommit> commits)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesGetFileHistoryResponse" /> class.
        /// </summary>
        public MemoryFilesGetFileHistoryResponse()
        {
        }
    }
}