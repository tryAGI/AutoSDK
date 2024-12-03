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
        [global::Newtonsoft.Json.JsonProperty("vcs", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Vcs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_lfs")]
        public bool? UseLfs { get; set; }

        /// <summary>
        /// The URL of the originating repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vcs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string VcsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("svc_root")]
        public string? SvcRoot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tfvc_project")]
        public string? TfvcProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImportStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_text")]
        public string? StatusText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_step")]
        public string? FailedStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("import_percent")]
        public int? ImportPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_count")]
        public int? CommitCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("push_percent")]
        public int? PushPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_large_files")]
        public bool? HasLargeFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("large_files_size")]
        public int? LargeFilesSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("large_files_count")]
        public int? LargeFilesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_choices")]
        public global::System.Collections.Generic.IList<global::G.ImportProjectChoice>? ProjectChoices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authors_count")]
        public int? AuthorsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authors_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthorsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("svn_root")]
        public string? SvnRoot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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