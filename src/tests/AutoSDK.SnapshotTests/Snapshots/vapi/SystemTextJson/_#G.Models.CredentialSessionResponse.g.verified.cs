//HintName: G.Models.CredentialSessionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialSessionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialSessionResponse" /> class.
        /// </summary>
        /// <param name="sessionToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialSessionResponse(
            string sessionToken)
        {
            this.SessionToken = sessionToken ?? throw new global::System.ArgumentNullException(nameof(sessionToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialSessionResponse" /> class.
        /// </summary>
        public CredentialSessionResponse()
        {
        }
    }
}