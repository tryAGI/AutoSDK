//HintName: G.Models.EvaluationCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationCreateRes
    {
        /// <summary>
        /// The digest of the created evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// The ID of the created evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// The version index of the created evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionIndex { get; set; }

        /// <summary>
        /// Full reference to the created evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluationRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCreateRes" /> class.
        /// </summary>
        /// <param name="digest">
        /// The digest of the created evaluation
        /// </param>
        /// <param name="objectId">
        /// The ID of the created evaluation
        /// </param>
        /// <param name="versionIndex">
        /// The version index of the created evaluation
        /// </param>
        /// <param name="evaluationRef">
        /// Full reference to the created evaluation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationCreateRes(
            string digest,
            string objectId,
            int versionIndex,
            string evaluationRef)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.VersionIndex = versionIndex;
            this.EvaluationRef = evaluationRef ?? throw new global::System.ArgumentNullException(nameof(evaluationRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCreateRes" /> class.
        /// </summary>
        public EvaluationCreateRes()
        {
        }
    }
}