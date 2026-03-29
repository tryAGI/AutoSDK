//HintName: G.Models.MedicalComprehendEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MedicalComprehendEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BeginOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long EndOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MedicalComprehendTrait> Traits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concepts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MedicalComprehendConcept> Concepts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MedicalComprehendAttribute> Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalComprehendEntity" /> class.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="beginOffset"></param>
        /// <param name="endOffset"></param>
        /// <param name="text"></param>
        /// <param name="traits"></param>
        /// <param name="concepts"></param>
        /// <param name="score"></param>
        /// <param name="attributes"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MedicalComprehendEntity(
            string category,
            long beginOffset,
            long endOffset,
            string text,
            global::System.Collections.Generic.IList<global::G.MedicalComprehendTrait> traits,
            global::System.Collections.Generic.IList<global::G.MedicalComprehendConcept> concepts,
            double score,
            global::System.Collections.Generic.IList<global::G.MedicalComprehendAttribute> attributes,
            string type)
        {
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.BeginOffset = beginOffset;
            this.EndOffset = endOffset;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Traits = traits ?? throw new global::System.ArgumentNullException(nameof(traits));
            this.Concepts = concepts ?? throw new global::System.ArgumentNullException(nameof(concepts));
            this.Score = score;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalComprehendEntity" /> class.
        /// </summary>
        public MedicalComprehendEntity()
        {
        }
    }
}