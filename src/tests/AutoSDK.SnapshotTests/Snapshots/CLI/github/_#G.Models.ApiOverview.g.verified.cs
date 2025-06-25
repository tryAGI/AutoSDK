﻿//HintName: G.Models.ApiOverview.g.cs

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
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifiable_password_authentication")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VerifiablePasswordAuthentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_key_fingerprints")]
        public global::G.ApiOverviewSshKeyFingerprints? SshKeyFingerprints { get; set; }

        /// <summary>
        /// Example: [ssh-ed25519 ABCDEFGHIJKLMNOPQRSTUVWXYZ]
        /// </summary>
        /// <example>[ssh-ed25519 ABCDEFGHIJKLMNOPQRSTUVWXYZ]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_keys")]
        public global::System.Collections.Generic.IList<string>? SshKeys { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        public global::System.Collections.Generic.IList<string>? Hooks { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_enterprise_importer")]
        public global::System.Collections.Generic.IList<string>? GithubEnterpriseImporter { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("web")]
        public global::System.Collections.Generic.IList<string>? Web { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        public global::System.Collections.Generic.IList<string>? Api { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("git")]
        public global::System.Collections.Generic.IList<string>? Git { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::System.Collections.Generic.IList<string>? Packages { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<string>? Pages { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("importer")]
        public global::System.Collections.Generic.IList<string>? Importer { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<string>? Actions { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions_macos")]
        public global::System.Collections.Generic.IList<string>? ActionsMacos { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("codespaces")]
        public global::System.Collections.Generic.IList<string>? Codespaces { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot")]
        public global::System.Collections.Generic.IList<string>? Dependabot { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        /// <example>[192.0.2.1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot")]
        public global::System.Collections.Generic.IList<string>? Copilot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::G.ApiOverviewDomains? Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverview" /> class.
        /// </summary>
        /// <param name="verifiablePasswordAuthentication">
        /// Example: true
        /// </param>
        /// <param name="sshKeyFingerprints"></param>
        /// <param name="sshKeys">
        /// Example: [ssh-ed25519 ABCDEFGHIJKLMNOPQRSTUVWXYZ]
        /// </param>
        /// <param name="hooks">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="githubEnterpriseImporter">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="web">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="api">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="git">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="packages">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="pages">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="importer">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="actions">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="actionsMacos">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="codespaces">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="dependabot">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="copilot">
        /// Example: [192.0.2.1]
        /// </param>
        /// <param name="domains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiOverview(
            bool verifiablePasswordAuthentication,
            global::G.ApiOverviewSshKeyFingerprints? sshKeyFingerprints,
            global::System.Collections.Generic.IList<string>? sshKeys,
            global::System.Collections.Generic.IList<string>? hooks,
            global::System.Collections.Generic.IList<string>? githubEnterpriseImporter,
            global::System.Collections.Generic.IList<string>? web,
            global::System.Collections.Generic.IList<string>? api,
            global::System.Collections.Generic.IList<string>? git,
            global::System.Collections.Generic.IList<string>? packages,
            global::System.Collections.Generic.IList<string>? pages,
            global::System.Collections.Generic.IList<string>? importer,
            global::System.Collections.Generic.IList<string>? actions,
            global::System.Collections.Generic.IList<string>? actionsMacos,
            global::System.Collections.Generic.IList<string>? codespaces,
            global::System.Collections.Generic.IList<string>? dependabot,
            global::System.Collections.Generic.IList<string>? copilot,
            global::G.ApiOverviewDomains? domains)
        {
            this.VerifiablePasswordAuthentication = verifiablePasswordAuthentication;
            this.SshKeyFingerprints = sshKeyFingerprints;
            this.SshKeys = sshKeys;
            this.Hooks = hooks;
            this.GithubEnterpriseImporter = githubEnterpriseImporter;
            this.Web = web;
            this.Api = api;
            this.Git = git;
            this.Packages = packages;
            this.Pages = pages;
            this.Importer = importer;
            this.Actions = actions;
            this.ActionsMacos = actionsMacos;
            this.Codespaces = codespaces;
            this.Dependabot = dependabot;
            this.Copilot = copilot;
            this.Domains = domains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverview" /> class.
        /// </summary>
        public ApiOverview()
        {
        }
    }
}