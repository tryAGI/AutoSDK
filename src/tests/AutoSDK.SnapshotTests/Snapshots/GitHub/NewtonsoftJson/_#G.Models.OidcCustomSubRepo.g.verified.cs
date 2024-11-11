//HintName: G.Models.OidcCustomSubRepo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Actions OIDC subject customization for a repository
    /// </summary>
    public sealed partial class OidcCustomSubRepo
    {
        /// <summary>
        /// Whether to use the default template or not. If `true`, the `include_claim_keys` field is ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_default", Required = global::Newtonsoft.Json.Required.Always)]
        public bool UseDefault { get; set; } = default!;

        /// <summary>
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_claim_keys")]
        public global::System.Collections.Generic.IList<string>? IncludeClaimKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcCustomSubRepo" /> class.
        /// </summary>
        /// <param name="useDefault">
        /// Whether to use the default template or not. If `true`, the `include_claim_keys` field is ignored.
        /// </param>
        /// <param name="includeClaimKeys">
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </param>
        public OidcCustomSubRepo(
            bool useDefault,
            global::System.Collections.Generic.IList<string>? includeClaimKeys)
        {
            this.UseDefault = useDefault;
            this.IncludeClaimKeys = includeClaimKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcCustomSubRepo" /> class.
        /// </summary>
        public OidcCustomSubRepo()
        {
        }
    }
}