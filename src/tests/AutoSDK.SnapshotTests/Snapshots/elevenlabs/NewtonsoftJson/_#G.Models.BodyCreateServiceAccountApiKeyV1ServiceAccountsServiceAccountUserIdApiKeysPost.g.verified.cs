//HintName: G.Models.BodyCreateServiceAccountApiKeyV1ServiceAccountsServiceAccountUserIdApiKeysPost.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The permissions of the XI API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.PermissionType>, string> Permissions { get; set; } = default!;

        /// <summary>
        /// The character limit of the XI API key. If provided this will limit the usage of this api key to n characters per month where n is the chosen value. Requests that incur charges will fail after reaching this monthly limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_limit")]
        public int? CharacterLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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