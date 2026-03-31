//HintName: G.Models.GetClientKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClientKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object AllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ClientKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClientKeyResponse" /> class.
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="clientKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetClientKeyResponse(
            object allowedDomains,
            object clientKey)
        {
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
            this.ClientKey = clientKey ?? throw new global::System.ArgumentNullException(nameof(clientKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClientKeyResponse" /> class.
        /// </summary>
        public GetClientKeyResponse()
        {
        }
    }
}