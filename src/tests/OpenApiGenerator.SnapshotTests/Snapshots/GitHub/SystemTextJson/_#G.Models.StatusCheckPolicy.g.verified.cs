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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Strict { get; set; }

        /// <summary>
        /// Example: [continuous-integration/travis-ci]
        /// </summary>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContextsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}