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
        [global::Newtonsoft.Json.JsonProperty("vcs_username")]
        public string? VcsUsername { get; set; }

        /// <summary>
        /// The password to provide to the originating repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vcs_password")]
        public string? VcsPassword { get; set; }

        /// <summary>
        /// The type of version control system you are migrating from.
        /// <br/>Example: "git"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vcs")]
        public MigrationsUpdateImportRequestVcs? Vcs { get; set; }

        /// <summary>
        /// For a tfvc import, the name of the project that is being imported.
        /// <br/>Example: "project1"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tfvc_project")]
        public string? TfvcProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}