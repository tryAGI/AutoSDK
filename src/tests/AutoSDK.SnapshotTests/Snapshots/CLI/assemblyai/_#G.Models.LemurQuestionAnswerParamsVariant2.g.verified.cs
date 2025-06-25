//HintName: G.Models.LemurQuestionAnswerParamsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurQuestionAnswerParamsVariant2
    {
        /// <summary>
        /// A list of questions to ask
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LemurQuestion> Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurQuestionAnswerParamsVariant2" /> class.
        /// </summary>
        /// <param name="questions">
        /// A list of questions to ask
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LemurQuestionAnswerParamsVariant2(
            global::System.Collections.Generic.IList<global::G.LemurQuestion> questions)
        {
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurQuestionAnswerParamsVariant2" /> class.
        /// </summary>
        public LemurQuestionAnswerParamsVariant2()
        {
        }
    }
}