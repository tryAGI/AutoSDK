//HintName: G.Models.GetAuthSessionInfoResponseOrgMember.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the authenticated user<br/>
    /// Example: {"id":"550e8400-e29b-41d4-a716-446655440002","email":"user@example.com","name":"John Doe","role":"admin"}
    /// </summary>
    public sealed partial class GetAuthSessionInfoResponseOrgMember
    {
        /// <summary>
        /// UUID identifier for the organization member<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440002
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440002</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Email address of the authenticated user<br/>
        /// Example: user@example.com
        /// </summary>
        /// <example>user@example.com</example>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Display name of the authenticated user<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Access role of the authenticated user within the organization<br/>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseOrgMember" /> class.
        /// </summary>
        /// <param name="id">
        /// UUID identifier for the organization member<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440002
        /// </param>
        /// <param name="email">
        /// Email address of the authenticated user<br/>
        /// Example: user@example.com
        /// </param>
        /// <param name="name">
        /// Display name of the authenticated user<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="role">
        /// Access role of the authenticated user within the organization<br/>
        /// Example: admin
        /// </param>
        public GetAuthSessionInfoResponseOrgMember(
            string id,
            string email,
            string name,
            string role)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseOrgMember" /> class.
        /// </summary>
        public GetAuthSessionInfoResponseOrgMember()
        {
        }
    }
}