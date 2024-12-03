//HintName: G.Models.SocialAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Social media account
    /// </summary>
    public sealed partial class SocialAccount
    {
        /// <summary>
        /// Example: linkedin
        /// </summary>
        /// <example>linkedin</example>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Example: https://www.linkedin.com/company/github/
        /// </summary>
        /// <example>https://www.linkedin.com/company/github/</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialAccount" /> class.
        /// </summary>
        /// <param name="provider">
        /// Example: linkedin
        /// </param>
        /// <param name="url">
        /// Example: https://www.linkedin.com/company/github/
        /// </param>
        public SocialAccount(
            string provider,
            string url)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialAccount" /> class.
        /// </summary>
        public SocialAccount()
        {
        }
    }
}