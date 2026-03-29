//HintName: G.Models.CreateEvaluationPipelineRequestScoreConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional custom scoring logic configuration.
    /// </summary>
    public sealed partial class CreateEvaluationPipelineRequestScoreConfiguration
    {
        /// <summary>
        /// Python or JavaScript code for score calculation. Receives 'data' variable (list of row dictionaries) and must return {'score': number}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Language of the code (defaults to PYTHON)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguageJsonConverter))]
        public global::G.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage? CodeLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineRequestScoreConfiguration" /> class.
        /// </summary>
        /// <param name="code">
        /// Python or JavaScript code for score calculation. Receives 'data' variable (list of row dictionaries) and must return {'score': number}.
        /// </param>
        /// <param name="codeLanguage">
        /// Language of the code (defaults to PYTHON)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvaluationPipelineRequestScoreConfiguration(
            string code,
            global::G.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage? codeLanguage)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.CodeLanguage = codeLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineRequestScoreConfiguration" /> class.
        /// </summary>
        public CreateEvaluationPipelineRequestScoreConfiguration()
        {
        }
    }
}