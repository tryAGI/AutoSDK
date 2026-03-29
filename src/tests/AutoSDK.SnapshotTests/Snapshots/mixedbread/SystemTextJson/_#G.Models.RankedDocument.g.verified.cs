//HintName: G.Models.RankedDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankedDocument
    {
        /// <summary>
        /// The index of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The score of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// The input document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// The object type.<br/>
        /// Default Value: rank_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankedDocument" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the document.
        /// </param>
        /// <param name="score">
        /// The score of the document.
        /// </param>
        /// <param name="input">
        /// The input document.
        /// </param>
        /// <param name="object">
        /// The object type.<br/>
        /// Default Value: rank_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankedDocument(
            int index,
            double score,
            object? input,
            string? @object)
        {
            this.Index = index;
            this.Score = score;
            this.Input = input;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankedDocument" /> class.
        /// </summary>
        public RankedDocument()
        {
        }
    }
}