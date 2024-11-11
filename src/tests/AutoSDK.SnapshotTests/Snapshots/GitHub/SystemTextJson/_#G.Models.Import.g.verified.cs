//HintName: G.Models.Import.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A repository import from an external source.
    /// </summary>
    public sealed partial class Import
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Vcs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_lfs")]
        public bool? UseLfs { get; set; }

        /// <summary>
        /// The URL of the originating repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VcsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svc_root")]
        public string? SvcRoot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tfvc_project")]
        public string? TfvcProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImportStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImportStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_text")]
        public string? StatusText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_step")]
        public string? FailedStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_percent")]
        public int? ImportPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_count")]
        public int? CommitCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_percent")]
        public int? PushPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_large_files")]
        public bool? HasLargeFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("large_files_size")]
        public int? LargeFilesSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("large_files_count")]
        public int? LargeFilesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_choices")]
        public global::System.Collections.Generic.IList<global::G.ImportProjectChoice>? ProjectChoices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors_count")]
        public int? AuthorsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthorsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svn_root")]
        public string? SvnRoot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Import" /> class.
        /// </summary>
        /// <param name="vcs"></param>
        /// <param name="useLfs"></param>
        /// <param name="vcsUrl">
        /// The URL of the originating repository.
        /// </param>
        /// <param name="svcRoot"></param>
        /// <param name="tfvcProject"></param>
        /// <param name="status"></param>
        /// <param name="statusText"></param>
        /// <param name="failedStep"></param>
        /// <param name="errorMessage"></param>
        /// <param name="importPercent"></param>
        /// <param name="commitCount"></param>
        /// <param name="pushPercent"></param>
        /// <param name="hasLargeFiles"></param>
        /// <param name="largeFilesSize"></param>
        /// <param name="largeFilesCount"></param>
        /// <param name="projectChoices"></param>
        /// <param name="message"></param>
        /// <param name="authorsCount"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="authorsUrl"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="svnRoot"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Import(
            string? vcs,
            string vcsUrl,
            global::G.ImportStatus status,
            string url,
            string htmlUrl,
            string authorsUrl,
            string repositoryUrl,
            bool? useLfs,
            string? svcRoot,
            string? tfvcProject,
            string? statusText,
            string? failedStep,
            string? errorMessage,
            int? importPercent,
            int? commitCount,
            int? pushPercent,
            bool? hasLargeFiles,
            int? largeFilesSize,
            int? largeFilesCount,
            global::System.Collections.Generic.IList<global::G.ImportProjectChoice>? projectChoices,
            string? message,
            int? authorsCount,
            string? svnRoot)
        {
            this.Vcs = vcs ?? throw new global::System.ArgumentNullException(nameof(vcs));
            this.VcsUrl = vcsUrl ?? throw new global::System.ArgumentNullException(nameof(vcsUrl));
            this.Status = status;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.AuthorsUrl = authorsUrl ?? throw new global::System.ArgumentNullException(nameof(authorsUrl));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.UseLfs = useLfs;
            this.SvcRoot = svcRoot;
            this.TfvcProject = tfvcProject;
            this.StatusText = statusText;
            this.FailedStep = failedStep;
            this.ErrorMessage = errorMessage;
            this.ImportPercent = importPercent;
            this.CommitCount = commitCount;
            this.PushPercent = pushPercent;
            this.HasLargeFiles = hasLargeFiles;
            this.LargeFilesSize = largeFilesSize;
            this.LargeFilesCount = largeFilesCount;
            this.ProjectChoices = projectChoices;
            this.Message = message;
            this.AuthorsCount = authorsCount;
            this.SvnRoot = svnRoot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Import" /> class.
        /// </summary>
        public Import()
        {
        }
    }
}