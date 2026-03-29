//HintName: G.Models.CategoricalFeedbackDefinitionUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalFeedbackDefinitionUpdate : global::G.FeedbackUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::G.CategoricalFeedbackDetailUpdate? Details { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CategoricalFeedbackDefinitionUpdate(
            string name,
            global::G.CategoricalFeedbackDetailUpdate? details)
        {
            this.Details = details;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionUpdate" /> class.
        /// </summary>
        public CategoricalFeedbackDefinitionUpdate()
        {
        }
    }
}