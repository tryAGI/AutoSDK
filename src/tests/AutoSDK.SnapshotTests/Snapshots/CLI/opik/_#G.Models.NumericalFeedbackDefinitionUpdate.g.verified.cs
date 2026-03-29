//HintName: G.Models.NumericalFeedbackDefinitionUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumericalFeedbackDefinitionUpdate : global::G.FeedbackUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::G.NumericalFeedbackDetailUpdate? Details { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDefinitionUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumericalFeedbackDefinitionUpdate(
            string name,
            global::G.NumericalFeedbackDetailUpdate? details)
        {
            this.Details = details;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumericalFeedbackDefinitionUpdate" /> class.
        /// </summary>
        public NumericalFeedbackDefinitionUpdate()
        {
        }
    }
}