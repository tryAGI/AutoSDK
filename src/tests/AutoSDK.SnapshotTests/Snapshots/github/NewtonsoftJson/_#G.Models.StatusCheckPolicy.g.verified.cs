﻿//HintName: G.Models.StatusCheckPolicy.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("strict", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Strict { get; set; } = default!;

        /// <summary>
        /// Example: [continuous-integration/travis-ci]
        /// </summary>
        /// <example>[continuous-integration/travis-ci]</example>
        [global::Newtonsoft.Json.JsonProperty("contexts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Contexts { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StatusCheckPolicyCheck> Checks { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_status_checks/contexts
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_status_checks/contexts</example>
        [global::Newtonsoft.Json.JsonProperty("contexts_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContextsUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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