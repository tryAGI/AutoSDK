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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2CreateOrUpdateParams" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: oauth2
        /// </param>
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