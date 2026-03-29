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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The email address of the linked account<br/>
        /// Example: user@example.com
        /// </summary>
        /// <example>user@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The display name of the linked account<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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