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
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public string Category { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MedicalComprehendAttribute> Attributes { get; set; } = default!;

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