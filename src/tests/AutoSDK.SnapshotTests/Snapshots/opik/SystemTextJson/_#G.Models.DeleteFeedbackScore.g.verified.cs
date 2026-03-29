//HintName: G.Models.DeleteFeedbackScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFeedbackScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFeedbackScore" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteFeedbackScore(
            string name,
            string? author)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Author = author;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFeedbackScore" /> class.
        /// </summary>
        public DeleteFeedbackScore()
        {
        }
    }
}