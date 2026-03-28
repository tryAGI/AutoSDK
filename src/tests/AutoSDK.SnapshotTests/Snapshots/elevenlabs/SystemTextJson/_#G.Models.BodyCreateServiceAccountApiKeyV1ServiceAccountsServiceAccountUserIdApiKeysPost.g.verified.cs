//HintName: G.Models.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The permissions of the XI API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.PermissionType>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PermissionType>, string> Permissions { get; set; }

        /// <summary>
        /// The character limit of the XI API key. If provided this will limit the usage of this api key to n characters per month where n is the chosen value. Requests that incur charges will fail after reaching this monthly limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        public int? CharacterLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="permissions">
        /// The permissions of the XI API.
        /// </param>
        /// <param name="characterLimit">
        /// The character limit of the XI API key. If provided this will limit the usage of this api key to n characters per month where n is the chosen value. Requests that incur charges will fail after reaching this monthly limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost(
            string name,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PermissionType>, string> permissions,
            int? characterLimit)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Permissions = permissions;
            this.CharacterLimit = characterLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost" /> class.
        /// </summary>
        public BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost()
        {
        }
    }
}