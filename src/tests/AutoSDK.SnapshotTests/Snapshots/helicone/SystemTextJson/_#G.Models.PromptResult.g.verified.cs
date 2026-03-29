//HintName: G.Models.PromptResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_defined_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserDefinedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pretty_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrettyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MajorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_model_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestModelUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Versions { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.RecordStringAny? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userDefinedId"></param>
        /// <param name="description"></param>
        /// <param name="prettyName"></param>
        /// <param name="majorVersion"></param>
        /// <param name="latestVersionId"></param>
        /// <param name="latestModelUsed"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUsed"></param>
        /// <param name="versions"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptResult(
            string id,
            string userDefinedId,
            string description,
            string prettyName,
            double majorVersion,
            string latestVersionId,
            string latestModelUsed,
            string createdAt,
            string lastUsed,
            global::System.Collections.Generic.IList<string> versions,
            global::G.RecordStringAny? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserDefinedId = userDefinedId ?? throw new global::System.ArgumentNullException(nameof(userDefinedId));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.PrettyName = prettyName ?? throw new global::System.ArgumentNullException(nameof(prettyName));
            this.MajorVersion = majorVersion;
            this.LatestVersionId = latestVersionId ?? throw new global::System.ArgumentNullException(nameof(latestVersionId));
            this.LatestModelUsed = latestModelUsed ?? throw new global::System.ArgumentNullException(nameof(latestModelUsed));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.LastUsed = lastUsed ?? throw new global::System.ArgumentNullException(nameof(lastUsed));
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResult" /> class.
        /// </summary>
        public PromptResult()
        {
        }
    }
}