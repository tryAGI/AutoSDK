//HintName: G.Models.ReposCreateForkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateForkRequest
    {
        /// <summary>
        /// Optional parameter to specify the organization name if forking into an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public string? Organization { get; set; }

        /// <summary>
        /// When forking from an existing repository, a new name for the fork.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When forking from an existing repository, fork with only the default branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch_only")]
        public bool DefaultBranchOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}