//HintName: G.Models.GetFederationResponseForConnectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFederationResponseForConnectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ConnectionKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFederationResponseForConnectionRequest" /> class.
        /// </summary>
        /// <param name="connectionKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFederationResponseForConnectionRequest(
            global::System.Guid connectionKey)
        {
            this.ConnectionKey = connectionKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFederationResponseForConnectionRequest" /> class.
        /// </summary>
        public GetFederationResponseForConnectionRequest()
        {
        }
    }
}