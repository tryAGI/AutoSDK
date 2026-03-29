//HintName: G.Models.GetCliGetSessionResponseAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the linked account, if any. Null if the session status is "pending".
    /// </summary>
    public sealed partial class GetCliGetSessionResponseAccount
    {
        /// <summary>
        /// The ID of the linked account<br/>
        /// Example: user_12345
        /// </summary>
        /// <example>user_12345</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The email address of the linked account<br/>
        /// Example: user@example.com
        /// </summary>
        /// <example>user@example.com</example>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// The display name of the linked account<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCliGetSessionResponseAccount" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the linked account<br/>
        /// Example: user_12345
        /// </param>
        /// <param name="email">
        /// The email address of the linked account<br/>
        /// Example: user@example.com
        /// </param>
        /// <param name="name">
        /// The display name of the linked account<br/>
        /// Example: John Doe
        /// </param>
        public GetCliGetSessionResponseAccount(
            string id,
            string email,
            string name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCliGetSessionResponseAccount" /> class.
        /// </summary>
        public GetCliGetSessionResponseAccount()
        {
        }
    }
}