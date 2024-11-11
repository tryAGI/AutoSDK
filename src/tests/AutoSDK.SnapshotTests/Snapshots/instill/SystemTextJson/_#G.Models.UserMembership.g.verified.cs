//HintName: G.Models.UserMembership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A user membership defines the relationship between a user and an<br/>
    /// organization they belong to.
    /// </summary>
    public sealed partial class UserMembership
    {
        /// <summary>
        /// The resource name of the membership, which allows its access by user and<br/>
        /// organization ID.<br/>
        /// - Format: `users/{user.id}/memberships/{organization.id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Role of the user in the organization.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// State of the membership.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MembershipStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MembershipState State { get; set; }

        /// <summary>
        /// User information.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Organization information.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMembership" /> class.
        /// </summary>
        /// <param name="name">
        /// The resource name of the membership, which allows its access by user and<br/>
        /// organization ID.<br/>
        /// - Format: `users/{user.id}/memberships/{organization.id}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="role">
        /// Role of the user in the organization.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// State of the membership.
        /// </param>
        /// <param name="user">
        /// User information.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Organization information.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UserMembership(
            global::G.MembershipState state,
            string? name,
            string? role,
            global::G.User? user,
            global::G.Organization? organization)
        {
            this.State = state;
            this.Name = name;
            this.Role = role;
            this.User = user;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMembership" /> class.
        /// </summary>
        public UserMembership()
        {
        }
    }
}