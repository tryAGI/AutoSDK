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
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MemoryFilesGetFileHistoryResponseCommit> Commits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesGetFileHistoryResponse" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="commits"></param>
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