//HintName: G.Models.OidcCustomSub.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Actions OIDC Subject customization
    /// </summary>
    public sealed partial class OidcCustomSub
    {
        /// <summary>
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_claim_keys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> IncludeClaimKeys { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcCustomSub" /> class.
        /// </summary>
        /// <param name="includeClaimKeys">
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </param>
        public OidcCustomSub(
            global::System.Collections.Generic.IList<string> includeClaimKeys)
        {
            this.IncludeClaimKeys = includeClaimKeys ?? throw new global::System.ArgumentNullException(nameof(includeClaimKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcCustomSub" /> class.
        /// </summary>
        public OidcCustomSub()
        {
        }
    }
}