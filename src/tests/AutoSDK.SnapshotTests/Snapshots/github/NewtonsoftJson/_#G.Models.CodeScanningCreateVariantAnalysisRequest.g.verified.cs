﻿//HintName: G.Models.CodeScanningCreateVariantAnalysisRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningCreateVariantAnalysisRequest
    {
        /// <summary>
        /// The language targeted by the CodeQL query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeScanningVariantAnalysisLanguage Language { get; set; } = default!;

        /// <summary>
        /// A Base64-encoded tarball containing a CodeQL query and all its dependencies
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_pack", Required = global::Newtonsoft.Json.Required.Always)]
        public string QueryPack { get; set; } = default!;

        /// <summary>
        /// List of repository names (in the form `owner/repo-name`) to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories")]
        public global::System.Collections.Generic.IList<string>? Repositories { get; set; }

        /// <summary>
        /// List of repository lists to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_lists")]
        public global::System.Collections.Generic.IList<string>? RepositoryLists { get; set; }

        /// <summary>
        /// List of organization or user names whose repositories the query should be run against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_owners")]
        public global::System.Collections.Generic.IList<string>? RepositoryOwners { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningCreateVariantAnalysisRequest" /> class.
        /// </summary>
        /// <param name="language">
        /// The language targeted by the CodeQL query
        /// </param>
        /// <param name="queryPack">
        /// A Base64-encoded tarball containing a CodeQL query and all its dependencies
        /// </param>
        /// <param name="repositories">
        /// List of repository names (in the form `owner/repo-name`) to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </param>
        /// <param name="repositoryLists">
        /// List of repository lists to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </param>
        /// <param name="repositoryOwners">
        /// List of organization or user names whose repositories the query should be run against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </param>
        public CodeScanningCreateVariantAnalysisRequest(
            global::G.CodeScanningVariantAnalysisLanguage language,
            string queryPack,
            global::System.Collections.Generic.IList<string>? repositories,
            global::System.Collections.Generic.IList<string>? repositoryLists,
            global::System.Collections.Generic.IList<string>? repositoryOwners)
        {
            this.Language = language;
            this.QueryPack = queryPack ?? throw new global::System.ArgumentNullException(nameof(queryPack));
            this.Repositories = repositories;
            this.RepositoryLists = repositoryLists;
            this.RepositoryOwners = repositoryOwners;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningCreateVariantAnalysisRequest" /> class.
        /// </summary>
        public CodeScanningCreateVariantAnalysisRequest()
        {
        }
    }
}