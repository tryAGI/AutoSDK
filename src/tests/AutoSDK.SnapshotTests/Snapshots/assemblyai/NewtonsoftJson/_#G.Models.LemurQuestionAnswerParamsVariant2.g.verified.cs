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
        [global::Newtonsoft.Json.JsonProperty("questions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LemurQuestion> Questions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurQuestionAnswerParamsVariant2" /> class.
        /// </summary>
        /// <param name="questions">
        /// A list of questions to ask
        /// </param>
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