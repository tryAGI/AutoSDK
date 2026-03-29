//HintName: G.Models.DescriptionMetaField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Description metadata field.
    /// </summary>
    public sealed partial class DescriptionMetaField
    {
        /// <summary>
        /// The confidence of the prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The origin of the prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionMetaField" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="confidence">
        /// The confidence of the prediction.
        /// </param>
        /// <param name="createdBy">
        /// The origin of the prediction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescriptionMetaField(
            string text,
            double? confidence,
            string? createdBy)
        {
            this.Confidence = confidence;
            this.CreatedBy = createdBy;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionMetaField" /> class.
        /// </summary>
        public DescriptionMetaField()
        {
        }
    }
}