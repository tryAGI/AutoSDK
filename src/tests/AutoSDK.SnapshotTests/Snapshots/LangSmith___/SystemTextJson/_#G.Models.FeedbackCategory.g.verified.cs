//HintName: G.Models.FeedbackCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specific value and label pair for feedback
    /// </summary>
    public sealed partial class FeedbackCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCategory" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="label"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FeedbackCategory(
            double value,
            string? label)
        {
            this.Value = value;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCategory" /> class.
        /// </summary>
        public FeedbackCategory()
        {
        }
    }
}