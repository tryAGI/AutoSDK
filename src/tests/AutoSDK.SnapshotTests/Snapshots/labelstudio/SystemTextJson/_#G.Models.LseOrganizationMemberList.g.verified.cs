//HintName: G.Models.LseOrganizationMemberList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A serializer mixin that takes an additional `fields` argument that controls<br/>
    /// which fields should be displayed.
    /// </summary>
    public sealed partial class LseOrganizationMemberList
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        public string Concurrency { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributed_to_projects")]
        public global::System.Collections.Generic.IList<global::G.LseOrganizationMemberListContributedToProject>? ContributedToProjects { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_projects")]
        public global::System.Collections.Generic.IList<global::G.LseOrganizationMemberListCreatedProject>? CreatedProjects { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Organization ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Organization { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::G.SimpleOrganizationMemberTag> Tags { get; set; } = default!;

        /// <summary>
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LseUserOrganizationMemberList User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseOrganizationMemberList" /> class.
        /// </summary>
        /// <param name="organization">
        /// Organization ID
        /// </param>
        /// <param name="user">
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </param>
        /// <param name="contributedToProjects">
        /// Included only in responses
        /// </param>
        /// <param name="createdProjects">
        /// Included only in responses
        /// </param>
        /// <param name="concurrency">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="role">
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseOrganizationMemberList(
            int organization,
            global::G.LseUserOrganizationMemberList user,
            global::System.Collections.Generic.IList<global::G.LseOrganizationMemberListContributedToProject>? contributedToProjects,
            global::System.Collections.Generic.IList<global::G.LseOrganizationMemberListCreatedProject>? createdProjects,
            string concurrency = default!,
            int id = default!,
            string role = default!,
            global::System.Collections.Generic.IList<global::G.SimpleOrganizationMemberTag> tags = default!)
        {
            this.Concurrency = concurrency;
            this.ContributedToProjects = contributedToProjects;
            this.CreatedProjects = createdProjects;
            this.Id = id;
            this.Organization = organization;
            this.Role = role;
            this.Tags = tags;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseOrganizationMemberList" /> class.
        /// </summary>
        public LseOrganizationMemberList()
        {
        }
    }
}