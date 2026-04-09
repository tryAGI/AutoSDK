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
        [global::Newtonsoft.Json.JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_valid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_role_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OrganizationPeopleOrganizationRoleTypeJsonConverter))]
        public global::G.OrganizationPeopleOrganizationRoleType? OrganizationRoleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("people_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OrganizationPeoplePeopleTypeJsonConverter))]
        public global::G.OrganizationPeoplePeopleType? PeopleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_nickname")]
        public string? UserNickname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_unique_name")]
        public string? UserUniqueName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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