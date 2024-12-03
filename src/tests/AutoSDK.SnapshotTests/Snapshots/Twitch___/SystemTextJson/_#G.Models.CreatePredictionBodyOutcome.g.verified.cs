//HintName: G.Models.CreatePredictionBodyOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionBodyOutcome
    {
        /// <summary>
        /// The text of one of the outcomes that the viewer may select. The title is limited to a maximum of 25 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionBodyOutcome" /> class.
        /// </summary>
        /// <param name="title">
        /// The text of one of the outcomes that the viewer may select. The title is limited to a maximum of 25 characters.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreatePredictionBodyOutcome(
            string title)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionBodyOutcome" /> class.
        /// </summary>
        public CreatePredictionBodyOutcome()
        {
        }
    }
}