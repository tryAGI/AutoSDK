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
        [global::System.Text.Json.Serialization.JsonPropertyName("include_claim_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> IncludeClaimKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcCustomSub" /> class.
        /// </summary>
        /// <param name="includeClaimKeys">
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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