﻿//HintName: G.Models.GistSimpleForkOf.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gist
    /// </summary>
    public sealed partial class GistSimpleForkOf
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ForksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_pull_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitPullUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_push_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitPushUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.GistSimpleForkOfFiles2> Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Comments { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommentsUrl { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::G.NullableSimpleUser? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        public bool? Truncated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks")]
        public global::System.Collections.Generic.IList<object>? Forks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<object>? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistSimpleForkOf" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="forksUrl"></param>
        /// <param name="commitsUrl"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="gitPullUrl"></param>
        /// <param name="gitPushUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="files"></param>
        /// <param name="public"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="comments"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="commentsUrl"></param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="truncated"></param>
        /// <param name="forks"></param>
        /// <param name="history"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GistSimpleForkOf(
            string url,
            string forksUrl,
            string commitsUrl,
            string id,
            string nodeId,
            string gitPullUrl,
            string gitPushUrl,
            string htmlUrl,
            global::System.Collections.Generic.Dictionary<string, global::G.GistSimpleForkOfFiles2> files,
            bool @public,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            int comments,
            global::G.NullableSimpleUser? user,
            string commentsUrl,
            global::G.NullableSimpleUser? owner,
            bool? truncated,
            global::System.Collections.Generic.IList<object>? forks,
            global::System.Collections.Generic.IList<object>? history)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ForksUrl = forksUrl ?? throw new global::System.ArgumentNullException(nameof(forksUrl));
            this.CommitsUrl = commitsUrl ?? throw new global::System.ArgumentNullException(nameof(commitsUrl));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.GitPullUrl = gitPullUrl ?? throw new global::System.ArgumentNullException(nameof(gitPullUrl));
            this.GitPushUrl = gitPushUrl ?? throw new global::System.ArgumentNullException(nameof(gitPushUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Public = @public;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Comments = comments;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.CommentsUrl = commentsUrl ?? throw new global::System.ArgumentNullException(nameof(commentsUrl));
            this.Owner = owner;
            this.Truncated = truncated;
            this.Forks = forks;
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistSimpleForkOf" /> class.
        /// </summary>
        public GistSimpleForkOf()
        {
        }
    }
}