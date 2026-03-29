//HintName: G.Models.ModelsPredictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsPredictions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face")]
        public global::G.FaceModelPredictions? Face { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prosody")]
        public global::G.ProsodyModelPredictions? Prosody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public global::G.LanguageModelPredictions? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("burst")]
        public global::G.BurstModelPredictions? Burst { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ner")]
        public global::G.NerModelPredictions? Ner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsPredictions" /> class.
        /// </summary>
        /// <param name="face"></param>
        /// <param name="prosody"></param>
        /// <param name="language"></param>
        /// <param name="burst"></param>
        /// <param name="ner"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsPredictions(
            global::G.FaceModelPredictions? face,
            global::G.ProsodyModelPredictions? prosody,
            global::G.LanguageModelPredictions? language,
            global::G.BurstModelPredictions? burst,
            global::G.NerModelPredictions? ner)
        {
            this.Face = face;
            this.Prosody = prosody;
            this.Language = language;
            this.Burst = burst;
            this.Ner = ner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsPredictions" /> class.
        /// </summary>
        public ModelsPredictions()
        {
        }
    }
}