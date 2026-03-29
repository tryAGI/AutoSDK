//HintName: G.Models.Password.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Password
    {
        /// <summary>
        /// The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// The corresponding password to the new user to create. <br/>
        /// The password must be a string of 8 to 64 characters and must include at least three of the following character types: uppercase letters, lowercase letters, numbers, and special characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Password" /> class.
        /// </summary>
        /// <param name="userName">
        /// The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.
        /// </param>
        /// <param name="password1">
        /// The corresponding password to the new user to create. <br/>
        /// The password must be a string of 8 to 64 characters and must include at least three of the following character types: uppercase letters, lowercase letters, numbers, and special characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Password(
            string userName,
            string password1)
        {
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Password1 = password1 ?? throw new global::System.ArgumentNullException(nameof(password1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Password" /> class.
        /// </summary>
        public Password()
        {
        }
    }
}