//HintName: G.Models.ModelFeedbackSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model feedback source.
    /// </summary>
    public sealed partial class ModelFeedbackSource
    {
        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFeedbackSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: model
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelFeedbackSource(
            string? type,
            object? metadata)
        {
            this.Type = type;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFeedbackSource" /> class.
        /// </summary>
        public ModelFeedbackSource()
        {
        }
    }
}