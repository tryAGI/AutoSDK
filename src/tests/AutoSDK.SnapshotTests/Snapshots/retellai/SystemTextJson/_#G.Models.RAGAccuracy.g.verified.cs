//HintName: G.Models.RAGAccuracy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGAccuracy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("false_positive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FalsePositive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("false_negative")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FalseNegative { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("true_positive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TruePositive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("true_negative")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TrueNegative { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAccuracy" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="falsePositive"></param>
        /// <param name="falseNegative"></param>
        /// <param name="truePositive"></param>
        /// <param name="trueNegative"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RAGAccuracy(
            double responseId,
            double falsePositive,
            double falseNegative,
            double truePositive,
            double trueNegative)
        {
            this.ResponseId = responseId;
            this.FalsePositive = falsePositive;
            this.FalseNegative = falseNegative;
            this.TruePositive = truePositive;
            this.TrueNegative = trueNegative;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGAccuracy" /> class.
        /// </summary>
        public RAGAccuracy()
        {
        }
    }
}