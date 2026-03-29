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
        [global::Newtonsoft.Json.JsonProperty("sessionToken", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialSessionResponse" /> class.
        /// </summary>
        /// <param name="sessionToken"></param>
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