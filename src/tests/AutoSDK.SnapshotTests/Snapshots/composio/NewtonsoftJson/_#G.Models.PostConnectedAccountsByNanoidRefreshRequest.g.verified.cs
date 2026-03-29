//HintName: G.Models.PostConnectedAccountsByNanoidRefreshRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsByNanoidRefreshRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// [EXPERIMENTAL] Whether to validate the provided credentials, validates only for API Key Auth scheme<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validate_credentials")]
        public bool? ValidateCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsByNanoidRefreshRequest" /> class.
        /// </summary>
        /// <param name="redirectUrl"></param>
        /// <param name="validateCredentials">
        /// [EXPERIMENTAL] Whether to validate the provided credentials, validates only for API Key Auth scheme<br/>
        /// Default Value: false
        /// </param>
        public PostConnectedAccountsByNanoidRefreshRequest(
            string? redirectUrl,
            bool? validateCredentials)
        {
            this.RedirectUrl = redirectUrl;
            this.ValidateCredentials = validateCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsByNanoidRefreshRequest" /> class.
        /// </summary>
        public PostConnectedAccountsByNanoidRefreshRequest()
        {
        }
    }
}