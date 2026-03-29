//HintName: G.Models.ApiUsersCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiUsersCreateRequest
    {
        /// <summary>
        /// Whether the user allows newsletters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_newsletters")]
        public bool? AllowNewsletters { get; set; }

        /// <summary>
        /// Avatar URL of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Email of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// First name of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Initials of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initials")]
        public string? Initials { get; set; }

        /// <summary>
        /// Last name of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Phone number of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Username of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUsersCreateRequest" /> class.
        /// </summary>
        /// <param name="allowNewsletters">
        /// Whether the user allows newsletters
        /// </param>
        /// <param name="avatar">
        /// Avatar URL of the user
        /// </param>
        /// <param name="email">
        /// Email of the user
        /// </param>
        /// <param name="firstName">
        /// First name of the user
        /// </param>
        /// <param name="id">
        /// User ID
        /// </param>
        /// <param name="initials">
        /// Initials of the user
        /// </param>
        /// <param name="lastName">
        /// Last name of the user
        /// </param>
        /// <param name="phone">
        /// Phone number of the user
        /// </param>
        /// <param name="username">
        /// Username of the user
        /// </param>
        public ApiUsersCreateRequest(
            bool? allowNewsletters,
            string? avatar,
            string? email,
            string? firstName,
            int? id,
            string? initials,
            string? lastName,
            string? phone,
            string? username)
        {
            this.AllowNewsletters = allowNewsletters;
            this.Avatar = avatar;
            this.Email = email;
            this.FirstName = firstName;
            this.Id = id;
            this.Initials = initials;
            this.LastName = lastName;
            this.Phone = phone;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUsersCreateRequest" /> class.
        /// </summary>
        public ApiUsersCreateRequest()
        {
        }
    }
}