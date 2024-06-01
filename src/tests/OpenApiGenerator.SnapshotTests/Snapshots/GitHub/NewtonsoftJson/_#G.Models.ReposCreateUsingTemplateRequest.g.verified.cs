//HintName: G.Models.ReposCreateUsingTemplateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateUsingTemplateRequest
    {
        /// <summary>
        /// The organization or person who will own the new repository. To create a new repository in an organization, the authenticated user must be a member of the specified organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// The name of the new repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A short description of the new repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Set to `true` to include the directory structure and files from all branches in the template repository, and not just the default branch. Default: `false`.
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_all_branches")]
        public bool IncludeAllBranches { get; set; } = false;

        /// <summary>
        /// Either `true` to create a new private repository or `false` to create a new public one.
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private")]
        public bool Private { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}