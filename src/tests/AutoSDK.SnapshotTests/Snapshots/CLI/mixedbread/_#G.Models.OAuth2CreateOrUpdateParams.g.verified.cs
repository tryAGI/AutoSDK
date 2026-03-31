//HintName: G.Models.OAuth2CreateOrUpdateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base class for OAuth2 create or update parameters.
    /// </summary>
    public sealed partial class OAuth2CreateOrUpdateParams
    {
        /// <summary>
        /// Default Value: oauth2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2CreateOrUpdateParams" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: oauth2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2CreateOrUpdateParams(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2CreateOrUpdateParams" /> class.
        /// </summary>
        public OAuth2CreateOrUpdateParams()
        {
        }
    }
}