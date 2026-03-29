//HintName: G.Models.OrganizationPeople.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationPeople
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_valid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_role_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrganizationPeopleOrganizationRoleTypeJsonConverter))]
        public global::G.OrganizationPeopleOrganizationRoleType? OrganizationRoleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("people_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrganizationPeoplePeopleTypeJsonConverter))]
        public global::G.OrganizationPeoplePeopleType? PeopleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_nickname")]
        public string? UserNickname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_unique_name")]
        public string? UserUniqueName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPeople" /> class.
        /// </summary>
        /// <param name="avatarUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="isValid"></param>
        /// <param name="organizationRoleType"></param>
        /// <param name="peopleType"></param>
        /// <param name="userId"></param>
        /// <param name="userNickname"></param>
        /// <param name="userUniqueName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationPeople(
            string? avatarUrl,
            int? createdAt,
            bool? isValid,
            global::G.OrganizationPeopleOrganizationRoleType? organizationRoleType,
            global::G.OrganizationPeoplePeopleType? peopleType,
            string? userId,
            string? userNickname,
            string? userUniqueName)
        {
            this.AvatarUrl = avatarUrl;
            this.CreatedAt = createdAt;
            this.IsValid = isValid;
            this.OrganizationRoleType = organizationRoleType;
            this.PeopleType = peopleType;
            this.UserId = userId;
            this.UserNickname = userNickname;
            this.UserUniqueName = userUniqueName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPeople" /> class.
        /// </summary>
        public OrganizationPeople()
        {
        }
    }
}