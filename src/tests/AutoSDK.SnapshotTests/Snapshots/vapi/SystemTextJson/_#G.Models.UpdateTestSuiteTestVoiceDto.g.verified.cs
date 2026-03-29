//HintName: G.Models.UpdateTestSuiteTestVoiceDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTestSuiteTestVoiceDto
    {
        /// <summary>
        /// These are the scorers used to evaluate the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorers")]
        public global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI>? Scorers { get; set; }

        /// <summary>
        /// This is the type of the test, which must be voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateTestSuiteTestVoiceDtoTypeJsonConverter))]
        public global::G.UpdateTestSuiteTestVoiceDtoType? Type { get; set; }

        /// <summary>
        /// This is the name of the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the script to be used for the voice test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        public string? Script { get; set; }

        /// <summary>
        /// This is the number of attempts allowed for the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numAttempts")]
        public double? NumAttempts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestSuiteTestVoiceDto" /> class.
        /// </summary>
        /// <param name="scorers">
        /// These are the scorers used to evaluate the test.
        /// </param>
        /// <param name="type">
        /// This is the type of the test, which must be voice.
        /// </param>
        /// <param name="name">
        /// This is the name of the test.
        /// </param>
        /// <param name="script">
        /// This is the script to be used for the voice test.
        /// </param>
        /// <param name="numAttempts">
        /// This is the number of attempts allowed for the test.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTestSuiteTestVoiceDto(
            global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI>? scorers,
            global::G.UpdateTestSuiteTestVoiceDtoType? type,
            string? name,
            string? script,
            double? numAttempts)
        {
            this.Scorers = scorers;
            this.Type = type;
            this.Name = name;
            this.Script = script;
            this.NumAttempts = numAttempts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestSuiteTestVoiceDto" /> class.
        /// </summary>
        public UpdateTestSuiteTestVoiceDto()
        {
        }
    }
}