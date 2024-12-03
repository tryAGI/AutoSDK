//HintName: G.Models.UsersCreateGpgKeyForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersCreateGpgKeyForAuthenticatedUserRequest
    {
        /// <summary>
        /// A descriptive name for the new key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A GPG key in ASCII-armored format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("armored_public_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArmoredPublicKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersCreateGpgKeyForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A descriptive name for the new key.
        /// </param>
        /// <param name="armoredPublicKey">
        /// A GPG key in ASCII-armored format.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UsersCreateGpgKeyForAuthenticatedUserRequest(
            string armoredPublicKey,
            string? name)
        {
            this.ArmoredPublicKey = armoredPublicKey ?? throw new global::System.ArgumentNullException(nameof(armoredPublicKey));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersCreateGpgKeyForAuthenticatedUserRequest" /> class.
        /// </summary>
        public UsersCreateGpgKeyForAuthenticatedUserRequest()
        {
        }
    }
}