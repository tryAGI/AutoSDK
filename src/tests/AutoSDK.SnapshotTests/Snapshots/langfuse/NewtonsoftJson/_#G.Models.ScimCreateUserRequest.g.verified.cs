//HintName: G.Models.ScimCreateUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScimCreateUserRequest
    {
        /// <summary>
        /// User's email address (required)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userName", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScimName Name { get; set; } = default!;

        /// <summary>
        /// User's email addresses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emails")]
        public global::System.Collections.Generic.IList<global::G.ScimEmail>? Emails { get; set; }

        /// <summary>
        /// Whether the user is active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Initial password for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimCreateUserRequest" /> class.
        /// </summary>
        /// <param name="userName">
        /// User's email address (required)
        /// </param>
        /// <param name="name"></param>
        /// <param name="emails">
        /// User's email addresses
        /// </param>
        /// <param name="active">
        /// Whether the user is active
        /// </param>
        /// <param name="password">
        /// Initial password for the user
        /// </param>
        public ScimCreateUserRequest(
            string userName,
            global::G.ScimName name,
            global::System.Collections.Generic.IList<global::G.ScimEmail>? emails,
            bool? active,
            string? password)
        {
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Emails = emails;
            this.Active = active;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimCreateUserRequest" /> class.
        /// </summary>
        public ScimCreateUserRequest()
        {
        }
    }
}