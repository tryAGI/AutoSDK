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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Example: https://www.linkedin.com/company/github/
        /// </summary>
        /// <example>https://www.linkedin.com/company/github/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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