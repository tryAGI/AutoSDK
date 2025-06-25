//HintName: G.Models.GistHistory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gist History
    /// </summary>
    public sealed partial class GistHistory
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committed_at")]
        public global::System.DateTime? CommittedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_status")]
        public global::G.GistHistoryChangeStatus? ChangeStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistHistory" /> class.
        /// </summary>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="version"></param>
        /// <param name="committedAt"></param>
        /// <param name="changeStatus"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GistHistory(
            global::G.NullableSimpleUser? user,
            string? version,
            global::System.DateTime? committedAt,
            global::G.GistHistoryChangeStatus? changeStatus,
            string? url)
        {
            this.User = user;
            this.Version = version;
            this.CommittedAt = committedAt;
            this.ChangeStatus = changeStatus;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistHistory" /> class.
        /// </summary>
        public GistHistory()
        {
        }
    }
}