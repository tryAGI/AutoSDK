//HintName: G.Models.OrganizationMember.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A serializer mixin that takes an additional `fields` argument that controls<br/>
    /// which fields should be displayed.
    /// </summary>
    public sealed partial class OrganizationMember
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("annotations_count")]
        public int AnnotationsCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("contributed_projects_count")]
        public int ContributedProjectsCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributed_to_projects")]
        public global::System.Collections.Generic.IList<global::G.OrganizationMemberContributedToProject>? ContributedToProjects { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_projects")]
        public global::System.Collections.Generic.IList<global::G.OrganizationMemberCreatedProject>? CreatedProjects { get; set; }

        /// <summary>
        /// Organization ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public int Organization { get; set; } = default!;

        /// <summary>
        /// User ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public int User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        /// <param name="organization">
        /// Organization ID
        /// </param>
        /// <param name="user">
        /// User ID
        /// </param>
        /// <param name="contributedToProjects">
        /// Included only in responses
        /// </param>
        /// <param name="createdProjects">
        /// Included only in responses
        /// </param>
        /// <param name="annotationsCount">
        /// Included only in responses
        /// </param>
        /// <param name="contributedProjectsCount">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        public OrganizationMember(
            int organization,
            int user,
            global::System.Collections.Generic.IList<global::G.OrganizationMemberContributedToProject>? contributedToProjects,
            global::System.Collections.Generic.IList<global::G.OrganizationMemberCreatedProject>? createdProjects,
            int annotationsCount = default!,
            int contributedProjectsCount = default!,
            global::System.DateTime createdAt = default!)
        {
            this.AnnotationsCount = annotationsCount;
            this.ContributedProjectsCount = contributedProjectsCount;
            this.ContributedToProjects = contributedToProjects;
            this.CreatedAt = createdAt;
            this.CreatedProjects = createdProjects;
            this.Organization = organization;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        public OrganizationMember()
        {
        }
    }
}