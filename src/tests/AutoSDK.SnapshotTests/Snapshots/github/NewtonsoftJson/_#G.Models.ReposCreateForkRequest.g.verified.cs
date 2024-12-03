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
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public string? Organization { get; set; }

        /// <summary>
        /// When forking from an existing repository, a new name for the fork.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When forking from an existing repository, fork with only the default branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_branch_only")]
        public bool? DefaultBranchOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateForkRequest" /> class.
        /// </summary>
        /// <param name="organization">
        /// Optional parameter to specify the organization name if forking into an organization.
        /// </param>
        /// <param name="name">
        /// When forking from an existing repository, a new name for the fork.
        /// </param>
        /// <param name="defaultBranchOnly">
        /// When forking from an existing repository, fork with only the default branch.
        /// </param>
        public ReposCreateForkRequest(
            string? organization,
            string? name,
            bool? defaultBranchOnly)
        {
            this.Organization = organization;
            this.Name = name;
            this.DefaultBranchOnly = defaultBranchOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateForkRequest" /> class.
        /// </summary>
        public ReposCreateForkRequest()
        {
        }
    }
}