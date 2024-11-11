//HintName: G.Models.CreateRepoCommitRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRepoCommitRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest", Required = global::Newtonsoft.Json.Required.Always)]
        public object Manifest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_commit")]
        public string? ParentCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("example_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExampleRunIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoCommitRequest" /> class.
        /// </summary>
        /// <param name="manifest"></param>
        /// <param name="parentCommit"></param>
        /// <param name="exampleRunIds"></param>
        public CreateRepoCommitRequest(
            object manifest,
            string? parentCommit,
            global::System.Collections.Generic.IList<global::System.Guid>? exampleRunIds)
        {
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.ParentCommit = parentCommit;
            this.ExampleRunIds = exampleRunIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoCommitRequest" /> class.
        /// </summary>
        public CreateRepoCommitRequest()
        {
        }
    }
}