﻿//HintName: G.Models.ReposCreateUsingTemplateRequest.g.cs

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
        /// Set to `true` to include the directory structure and files from all branches in the template repository, and not just the default branch. Default: `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_all_branches")]
        public bool? IncludeAllBranches { get; set; }

        /// <summary>
        /// Either `true` to create a new private repository or `false` to create a new public one.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateUsingTemplateRequest" /> class.
        /// </summary>
        /// <param name="owner">
        /// The organization or person who will own the new repository. To create a new repository in an organization, the authenticated user must be a member of the specified organization.
        /// </param>
        /// <param name="name">
        /// The name of the new repository.
        /// </param>
        /// <param name="description">
        /// A short description of the new repository.
        /// </param>
        /// <param name="includeAllBranches">
        /// Set to `true` to include the directory structure and files from all branches in the template repository, and not just the default branch. Default: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="private">
        /// Either `true` to create a new private repository or `false` to create a new public one.<br/>
        /// Default Value: false
        /// </param>
        public ReposCreateUsingTemplateRequest(
            string name,
            string? owner,
            string? description,
            bool? includeAllBranches,
            bool? @private)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner;
            this.Description = description;
            this.IncludeAllBranches = includeAllBranches;
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateUsingTemplateRequest" /> class.
        /// </summary>
        public ReposCreateUsingTemplateRequest()
        {
        }
    }
}