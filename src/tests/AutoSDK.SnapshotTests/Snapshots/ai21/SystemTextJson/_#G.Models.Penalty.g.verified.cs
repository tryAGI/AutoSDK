//HintName: G.Models.Penalty.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Penalty
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Scale { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyToWhitespaces")]
        public bool? ApplyToWhitespaces { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyToPunctuations")]
        public bool? ApplyToPunctuations { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyToNumbers")]
        public bool? ApplyToNumbers { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyToStopwords")]
        public bool? ApplyToStopwords { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyToEmojis")]
        public bool? ApplyToEmojis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Penalty" /> class.
        /// </summary>
        /// <param name="scale"></param>
        /// <param name="applyToWhitespaces">
        /// Default Value: true
        /// </param>
        /// <param name="applyToPunctuations">
        /// Default Value: true
        /// </param>
        /// <param name="applyToNumbers">
        /// Default Value: true
        /// </param>
        /// <param name="applyToStopwords">
        /// Default Value: true
        /// </param>
        /// <param name="applyToEmojis">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Penalty(
            double scale,
            bool? applyToWhitespaces,
            bool? applyToPunctuations,
            bool? applyToNumbers,
            bool? applyToStopwords,
            bool? applyToEmojis)
        {
            this.Scale = scale;
            this.ApplyToWhitespaces = applyToWhitespaces;
            this.ApplyToPunctuations = applyToPunctuations;
            this.ApplyToNumbers = applyToNumbers;
            this.ApplyToStopwords = applyToStopwords;
            this.ApplyToEmojis = applyToEmojis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Penalty" /> class.
        /// </summary>
        public Penalty()
        {
        }
    }
}