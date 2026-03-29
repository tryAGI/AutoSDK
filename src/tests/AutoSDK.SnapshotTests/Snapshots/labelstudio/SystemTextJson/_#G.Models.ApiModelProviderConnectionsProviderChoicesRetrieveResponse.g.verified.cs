//HintName: G.Models.ApiModelProviderConnectionsProviderChoicesRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiModelProviderConnectionsProviderChoicesRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_choices")]
        public global::System.Collections.Generic.IList<string>? ProviderChoices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiModelProviderConnectionsProviderChoicesRetrieveResponse" /> class.
        /// </summary>
        /// <param name="providerChoices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiModelProviderConnectionsProviderChoicesRetrieveResponse(
            global::System.Collections.Generic.IList<string>? providerChoices)
        {
            this.ProviderChoices = providerChoices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiModelProviderConnectionsProviderChoicesRetrieveResponse" /> class.
        /// </summary>
        public ApiModelProviderConnectionsProviderChoicesRetrieveResponse()
        {
        }
    }
}