//HintName: G.Models.ScorerReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScorerReadRes
    {
        /// <summary>
        /// The scorer ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// The digest of the scorer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// The version index of the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionIndex { get; set; } = default!;

        /// <summary>
        /// When the scorer was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the scorer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the scorer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The Scorer.score op reference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_op", Required = global::Newtonsoft.Json.Required.Always)]
        public string ScoreOp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScorerReadRes" /> class.
        /// </summary>
        /// <param name="objectId">
        /// The scorer ID
        /// </param>
        /// <param name="digest">
        /// The digest of the scorer
        /// </param>
        /// <param name="versionIndex">
        /// The version index of the object
        /// </param>
        /// <param name="createdAt">
        /// When the scorer was created
        /// </param>
        /// <param name="name">
        /// The name of the scorer
        /// </param>
        /// <param name="scoreOp">
        /// The Scorer.score op reference
        /// </param>
        /// <param name="description">
        /// Description of the scorer
        /// </param>
        public ScorerReadRes(
            string objectId,
            string digest,
            int versionIndex,
            global::System.DateTime createdAt,
            string name,
            string scoreOp,
            string? description)
        {
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.VersionIndex = versionIndex;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ScoreOp = scoreOp ?? throw new global::System.ArgumentNullException(nameof(scoreOp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScorerReadRes" /> class.
        /// </summary>
        public ScorerReadRes()
        {
        }
    }
}