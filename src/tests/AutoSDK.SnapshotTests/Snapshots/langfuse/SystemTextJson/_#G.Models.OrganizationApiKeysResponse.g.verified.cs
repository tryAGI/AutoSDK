//HintName: G.Models.OrganizationApiKeysResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationApiKeysResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OrganizationApiKey> ApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApiKeysResponse" /> class.
        /// </summary>
        /// <param name="apiKeys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationApiKeysResponse(
            global::System.Collections.Generic.IList<global::G.OrganizationApiKey> apiKeys)
        {
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApiKeysResponse" /> class.
        /// </summary>
        public OrganizationApiKeysResponse()
        {
        }
    }
}