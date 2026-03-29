//HintName: G.Models.CreateTestSuiteTestVoiceDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTestSuiteTestVoiceDto
    {
        /// <summary>
        /// These are the scorers used to evaluate the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI> Scorers { get; set; }

        /// <summary>
        /// This is the type of the test, which must be voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTestSuiteTestVoiceDtoTypeJsonConverter))]
        public global::G.CreateTestSuiteTestVoiceDtoType Type { get; set; }

        /// <summary>
        /// This is the script to be used for the voice test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Script { get; set; }

        /// <summary>
        /// This is the number of attempts allowed for the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numAttempts")]
        public double? NumAttempts { get; set; }

        /// <summary>
        /// This is the name of the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTestSuiteTestVoiceDto" /> class.
        /// </summary>
        /// <param name="scorers">
        /// These are the scorers used to evaluate the test.
        /// </param>
        /// <param name="script">
        /// This is the script to be used for the voice test.
        /// </param>
        /// <param name="type">
        /// This is the type of the test, which must be voice.
        /// </param>
        /// <param name="numAttempts">
        /// This is the number of attempts allowed for the test.
        /// </param>
        /// <param name="name">
        /// This is the name of the test.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTestSuiteTestVoiceDto(
            global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI> scorers,
            string script,
            global::G.CreateTestSuiteTestVoiceDtoType type,
            double? numAttempts,
            string? name)
        {
            this.Scorers = scorers ?? throw new global::System.ArgumentNullException(nameof(scorers));
            this.Type = type;
            this.Script = script ?? throw new global::System.ArgumentNullException(nameof(script));
            this.NumAttempts = numAttempts;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTestSuiteTestVoiceDto" /> class.
        /// </summary>
        public CreateTestSuiteTestVoiceDto()
        {
        }
    }
}