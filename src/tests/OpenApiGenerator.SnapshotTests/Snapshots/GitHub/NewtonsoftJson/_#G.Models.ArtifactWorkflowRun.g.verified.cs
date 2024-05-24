//HintName: G.Models.ArtifactWorkflowRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactWorkflowRun
    {
        /// <summary>
        /// <br/>Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_id")]
        public int RepositoryId { get; set; }

        /// <summary>
        /// <br/>Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_repository_id")]
        public int HeadRepositoryId { get; set; }

        /// <summary>
        /// <br/>Example: main
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_branch")]
        public string? HeadBranch { get; set; }

        /// <summary>
        /// <br/>Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha")]
        public string? HeadSha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}