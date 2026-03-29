//HintName: G.Models.AccountResponseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountResponseBody
    {
        /// <summary>
        /// The user's email<br/>
        /// Example: example@stability.ai
        /// </summary>
        /// <example>example@stability.ai</example>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// The user's ID<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The user's organizations<br/>
        /// Example: [{"id":"org-5678","name":"Another Organization","role":"MEMBER","is_default":true}, {"id":"org-1234","name":"My Organization","role":"MEMBER","is_default":false}]
        /// </summary>
        /// <example>[{"id":"org-5678","name":"Another Organization","role":"MEMBER","is_default":true}, {"id":"org-1234","name":"My Organization","role":"MEMBER","is_default":false}]</example>
        [global::Newtonsoft.Json.JsonProperty("organizations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OrganizationMembership> Organizations { get; set; } = default!;

        /// <summary>
        /// The user's profile picture<br/>
        /// Example: https://api.stability.ai/example.png
        /// </summary>
        /// <example>https://api.stability.ai/example.png</example>
        [global::Newtonsoft.Json.JsonProperty("profile_picture")]
        public string? ProfilePicture { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResponseBody" /> class.
        /// </summary>
        /// <param name="email">
        /// The user's email<br/>
        /// Example: example@stability.ai
        /// </param>
        /// <param name="id">
        /// The user's ID<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="organizations">
        /// The user's organizations<br/>
        /// Example: [{"id":"org-5678","name":"Another Organization","role":"MEMBER","is_default":true}, {"id":"org-1234","name":"My Organization","role":"MEMBER","is_default":false}]
        /// </param>
        /// <param name="profilePicture">
        /// The user's profile picture<br/>
        /// Example: https://api.stability.ai/example.png
        /// </param>
        public AccountResponseBody(
            string email,
            string id,
            global::System.Collections.Generic.IList<global::G.OrganizationMembership> organizations,
            string? profilePicture)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Organizations = organizations ?? throw new global::System.ArgumentNullException(nameof(organizations));
            this.ProfilePicture = profilePicture;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResponseBody" /> class.
        /// </summary>
        public AccountResponseBody()
        {
        }
    }
}