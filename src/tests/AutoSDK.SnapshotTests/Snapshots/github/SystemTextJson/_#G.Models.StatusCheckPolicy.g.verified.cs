//HintName: G.Models.StatusCheckPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status Check Policy
    /// </summary>
    public sealed partial class StatusCheckPolicy
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_status_checks
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_status_checks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Strict { get; set; }

        /// <summary>
        /// Example: [continuous-integration/travis-ci]
        /// </summary>
        /// <example>[continuous-integration/travis-ci]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Contexts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StatusCheckPolicyCheck> Checks { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_status_checks/contexts
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_status_checks/contexts</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCheckPolicy" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_status_checks
        /// </param>
        /// <param name="strict">
        /// Example: true
        /// </param>
        /// <param name="contexts">
        /// Example: [continuous-integration/travis-ci]
        /// </param>
        /// <param name="checks"></param>
        /// <param name="contextsUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_status_checks/contexts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatusCheckPolicy(
            string url,
            bool strict,
            global::System.Collections.Generic.IList<string> contexts,
            global::System.Collections.Generic.IList<global::G.StatusCheckPolicyCheck> checks,
            string contextsUrl)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Strict = strict;
            this.Contexts = contexts ?? throw new global::System.ArgumentNullException(nameof(contexts));
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
            this.ContextsUrl = contextsUrl ?? throw new global::System.ArgumentNullException(nameof(contextsUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCheckPolicy" /> class.
        /// </summary>
        public StatusCheckPolicy()
        {
        }
    }
}