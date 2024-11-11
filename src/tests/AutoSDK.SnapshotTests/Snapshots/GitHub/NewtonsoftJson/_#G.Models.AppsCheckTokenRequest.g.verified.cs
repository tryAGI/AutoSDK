//HintName: G.Models.AppsCheckTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsCheckTokenRequest
    {
        /// <summary>
        /// The access_token of the OAuth or GitHub application.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsCheckTokenRequest" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// The access_token of the OAuth or GitHub application.
        /// </param>
        public AppsCheckTokenRequest(
            string accessToken)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsCheckTokenRequest" /> class.
        /// </summary>
        public AppsCheckTokenRequest()
        {
        }
    }
}