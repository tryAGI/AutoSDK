//HintName: G.Models.ApiOverview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Api Overview
    /// </summary>
    public sealed partial class ApiOverview
    {
        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verifiable_password_authentication", Required = global::Newtonsoft.Json.Required.Always)]
        public bool VerifiablePasswordAuthentication { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ssh_key_fingerprints")]
        public global::G.ApiOverviewSshKeyFingerprints? SshKeyFingerprints { get; set; }

        /// <summary>
        /// Example: [ssh-ed25519 ABCDEFGHIJKLMNOPQRSTUVWXYZ]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ssh_keys")]
        public global::System.Collections.Generic.IList<string?>? SshKeys { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks")]
        public global::System.Collections.Generic.IList<string?>? Hooks { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_enterprise_importer")]
        public global::System.Collections.Generic.IList<string?>? GithubEnterpriseImporter { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web")]
        public global::System.Collections.Generic.IList<string?>? Web { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api")]
        public global::System.Collections.Generic.IList<string?>? Api { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("git")]
        public global::System.Collections.Generic.IList<string?>? Git { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("packages")]
        public global::System.Collections.Generic.IList<string?>? Packages { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages")]
        public global::System.Collections.Generic.IList<string?>? Pages { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("importer")]
        public global::System.Collections.Generic.IList<string?>? Importer { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actions")]
        public global::System.Collections.Generic.IList<string?>? Actions { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actions_macos")]
        public global::System.Collections.Generic.IList<string?>? ActionsMacos { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependabot")]
        public global::System.Collections.Generic.IList<string?>? Dependabot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domains")]
        public global::G.ApiOverviewDomains? Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}