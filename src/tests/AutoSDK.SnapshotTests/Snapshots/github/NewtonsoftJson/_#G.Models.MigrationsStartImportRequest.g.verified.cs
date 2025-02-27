﻿//HintName: G.Models.MigrationsStartImportRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsStartImportRequest
    {
        /// <summary>
        /// The URL of the originating repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vcs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string VcsUrl { get; set; } = default!;

        /// <summary>
        /// The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vcs")]
        public global::G.MigrationsStartImportRequestVcs? Vcs { get; set; }

        /// <summary>
        /// If authentication is required, the username to provide to `vcs_url`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vcs_username")]
        public string? VcsUsername { get; set; }

        /// <summary>
        /// If authentication is required, the password to provide to `vcs_url`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vcs_password")]
        public string? VcsPassword { get; set; }

        /// <summary>
        /// For a tfvc import, the name of the project that is being imported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tfvc_project")]
        public string? TfvcProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsStartImportRequest" /> class.
        /// </summary>
        /// <param name="vcsUrl">
        /// The URL of the originating repository.
        /// </param>
        /// <param name="vcs">
        /// The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response.
        /// </param>
        /// <param name="vcsUsername">
        /// If authentication is required, the username to provide to `vcs_url`.
        /// </param>
        /// <param name="vcsPassword">
        /// If authentication is required, the password to provide to `vcs_url`.
        /// </param>
        /// <param name="tfvcProject">
        /// For a tfvc import, the name of the project that is being imported.
        /// </param>
        public MigrationsStartImportRequest(
            string vcsUrl,
            global::G.MigrationsStartImportRequestVcs? vcs,
            string? vcsUsername,
            string? vcsPassword,
            string? tfvcProject)
        {
            this.VcsUrl = vcsUrl ?? throw new global::System.ArgumentNullException(nameof(vcsUrl));
            this.Vcs = vcs;
            this.VcsUsername = vcsUsername;
            this.VcsPassword = vcsPassword;
            this.TfvcProject = tfvcProject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsStartImportRequest" /> class.
        /// </summary>
        public MigrationsStartImportRequest()
        {
        }
    }
}