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
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The public SSH key to add to your GitHub account. For more information, see "[Checking for existing SSH keys](https://docs.github.com/authentication/connecting-to-github-with-ssh/checking-for-existing-ssh-keys)."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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