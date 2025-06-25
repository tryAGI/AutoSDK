﻿//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunHeadCommitAuthor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metaproperties for Git author/committer information.
    /// </summary>
    public sealed partial class WebhookWorkflowRunCompletedWorkflowRunHeadCommitAuthor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Email { get; set; }

        /// <summary>
        /// The git author's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunCompletedWorkflowRunHeadCommitAuthor" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="email"></param>
        /// <param name="name">
        /// The git author's name.
        /// </param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookWorkflowRunCompletedWorkflowRunHeadCommitAuthor(
            string? email,
            string name,
            global::System.DateTime? date,
            string? username)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Date = date;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunCompletedWorkflowRunHeadCommitAuthor" /> class.
        /// </summary>
        public WebhookWorkflowRunCompletedWorkflowRunHeadCommitAuthor()
        {
        }
    }
}