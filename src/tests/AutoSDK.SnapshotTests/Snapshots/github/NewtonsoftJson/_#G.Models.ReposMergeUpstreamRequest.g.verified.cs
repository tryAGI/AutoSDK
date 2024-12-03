//HintName: G.Models.ReposMergeUpstreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposMergeUpstreamRequest
    {
        /// <summary>
        /// The name of the branch which should be updated to match upstream.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string Branch { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposMergeUpstreamRequest" /> class.
        /// </summary>
        /// <param name="branch">
        /// The name of the branch which should be updated to match upstream.
        /// </param>
        public ReposMergeUpstreamRequest(
            string branch)
        {
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposMergeUpstreamRequest" /> class.
        /// </summary>
        public ReposMergeUpstreamRequest()
        {
        }
    }
}