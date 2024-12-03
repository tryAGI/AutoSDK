//HintName: G.Models.UsersCreateSshSigningKeyForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersCreateSshSigningKeyForAuthenticatedUserRequest
    {
        /// <summary>
        /// A descriptive name for the new key.<br/>
        /// Example: Personal MacBook Air
        /// </summary>
        /// <example>Personal MacBook Air</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The public SSH key to add to your GitHub account. For more information, see "[Checking for existing SSH keys](https://docs.github.com/authentication/connecting-to-github-with-ssh/checking-for-existing-ssh-keys)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersCreateSshSigningKeyForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// A descriptive name for the new key.<br/>
        /// Example: Personal MacBook Air
        /// </param>
        /// <param name="key">
        /// The public SSH key to add to your GitHub account. For more information, see "[Checking for existing SSH keys](https://docs.github.com/authentication/connecting-to-github-with-ssh/checking-for-existing-ssh-keys)."
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UsersCreateSshSigningKeyForAuthenticatedUserRequest(
            string key,
            string? title)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersCreateSshSigningKeyForAuthenticatedUserRequest" /> class.
        /// </summary>
        public UsersCreateSshSigningKeyForAuthenticatedUserRequest()
        {
        }
    }
}