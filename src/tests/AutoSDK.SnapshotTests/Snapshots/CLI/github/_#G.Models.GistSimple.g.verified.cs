﻿//HintName: G.Models.GistSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gist Simple
    /// </summary>
    public sealed partial class GistSimple
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.GistSimpleFork>? Forks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.GistHistory>? History { get; set; }

        /// <summary>
        /// Gist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fork_of")]
        public global::G.GistSimpleForkOf? ForkOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_url")]
        public string? ForksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        public string? CommitsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_pull_url")]
        public string? GitPullUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_push_url")]
        public string? GitPushUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.Dictionary<string, global::G.GistSimpleFiles2?>? Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        public string? CommentsUrl { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::G.SimpleUser? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        public bool? Truncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistSimple" /> class.
        /// </summary>
        /// <param name="forkOf">
        /// Gist
        /// </param>
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
        /// <param name="user"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="truncated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GistSimple(
            global::G.GistSimpleForkOf? forkOf,
            string? url,
            string? forksUrl,
            string? commitsUrl,
            string? id,
            string? nodeId,
            string? gitPullUrl,
            string? gitPushUrl,
            string? htmlUrl,
            global::System.Collections.Generic.Dictionary<string, global::G.GistSimpleFiles2?>? files,
            bool? @public,
            string? createdAt,
            string? updatedAt,
            string? description,
            int? comments,
            string? user,
            string? commentsUrl,
            global::G.SimpleUser? owner,
            bool? truncated)
        {
            this.ForkOf = forkOf;
            this.Url = url;
            this.ForksUrl = forksUrl;
            this.CommitsUrl = commitsUrl;
            this.Id = id;
            this.NodeId = nodeId;
            this.GitPullUrl = gitPullUrl;
            this.GitPushUrl = gitPushUrl;
            this.HtmlUrl = htmlUrl;
            this.Files = files;
            this.Public = @public;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.Comments = comments;
            this.User = user;
            this.CommentsUrl = commentsUrl;
            this.Owner = owner;
            this.Truncated = truncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistSimple" /> class.
        /// </summary>
        public GistSimple()
        {
        }
    }
}