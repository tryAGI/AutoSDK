//HintName: G.Models.MedicalComprehendAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MedicalComprehendAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relationship_score", Required = global::Newtonsoft.Json.Required.Always)]
        public double RelationshipScore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("begin_offset", Required = global::Newtonsoft.Json.Required.Always)]
        public long BeginOffset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_offset", Required = global::Newtonsoft.Json.Required.Always)]
        public long EndOffset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MedicalComprehendTrait> Traits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concepts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MedicalComprehendConcept> Concepts { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relationship_type")]
        public string? RelationshipType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalComprehendAttribute" /> class.
        /// </summary>
        /// <param name="relationshipScore"></param>
        /// <param name="beginOffset"></param>
        /// <param name="endOffset"></param>
        /// <param name="text"></param>
        /// <param name="traits"></param>
        /// <param name="concepts"></param>
        /// <param name="score"></param>
        /// <param name="type"></param>
        /// <param name="category"></param>
        /// <param name="relationshipType"></param>
        public MedicalComprehendAttribute(
            double relationshipScore,
            long beginOffset,
            long endOffset,
            string text,
            global::System.Collections.Generic.IList<global::G.MedicalComprehendTrait> traits,
            global::System.Collections.Generic.IList<global::G.MedicalComprehendConcept> concepts,
            double score,
            string type,
            string? category,
            string? relationshipType)
        {
            this.Category = category;
            this.RelationshipScore = relationshipScore;
            this.BeginOffset = beginOffset;
            this.EndOffset = endOffset;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Traits = traits ?? throw new global::System.ArgumentNullException(nameof(traits));
            this.Concepts = concepts ?? throw new global::System.ArgumentNullException(nameof(concepts));
            this.Score = score;
            this.RelationshipType = relationshipType;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalComprehendAttribute" /> class.
        /// </summary>
        public MedicalComprehendAttribute()
        {
        }
    }
}