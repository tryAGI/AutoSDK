//HintName: G.Models.MigrationsUpdateImportRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsUpdateImportRequest
    {
        /// <summary>
        /// The username to provide to the originating repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcs_username")]
        public string? VcsUsername { get; set; }

        /// <summary>
        /// The password to provide to the originating repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcs_password")]
        public string? VcsPassword { get; set; }

        /// <summary>
        /// The type of version control system you are migrating from.<br/>
        /// Example: "git"
        /// </summary>
        /// <example>"git"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MigrationsUpdateImportRequestVcsJsonConverter))]
        public global::G.MigrationsUpdateImportRequestVcs? Vcs { get; set; }

        /// <summary>
        /// For a tfvc import, the name of the project that is being imported.<br/>
        /// Example: "project1"
        /// </summary>
        /// <example>"project1"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tfvc_project")]
        public string? TfvcProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsUpdateImportRequest" /> class.
        /// </summary>
        /// <param name="vcsUsername">
        /// The username to provide to the originating repository.
        /// </param>
        /// <param name="vcsPassword">
        /// The password to provide to the originating repository.
        /// </param>
        /// <param name="vcs">
        /// The type of version control system you are migrating from.<br/>
        /// Example: "git"
        /// </param>
        /// <param name="tfvcProject">
        /// For a tfvc import, the name of the project that is being imported.<br/>
        /// Example: "project1"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MigrationsUpdateImportRequest(
            string? vcsUsername,
            string? vcsPassword,
            global::G.MigrationsUpdateImportRequestVcs? vcs,
            string? tfvcProject)
        {
            this.VcsUsername = vcsUsername;
            this.VcsPassword = vcsPassword;
            this.Vcs = vcs;
            this.TfvcProject = tfvcProject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsUpdateImportRequest" /> class.
        /// </summary>
        public MigrationsUpdateImportRequest()
        {
        }
    }
}