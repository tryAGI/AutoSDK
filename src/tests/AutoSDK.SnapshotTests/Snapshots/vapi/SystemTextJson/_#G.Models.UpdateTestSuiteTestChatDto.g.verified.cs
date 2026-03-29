//HintName: G.Models.UpdateTestSuiteTestChatDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTestSuiteTestChatDto
    {
        /// <summary>
        /// These are the scorers used to evaluate the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorers")]
        public global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI>? Scorers { get; set; }

        /// <summary>
        /// This is the type of the test, which must be chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateTestSuiteTestChatDtoTypeJsonConverter))]
        public global::G.UpdateTestSuiteTestChatDtoType? Type { get; set; }

        /// <summary>
        /// This is the name of the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the script to be used for the chat test.
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
        /// Initializes a new instance of the <see cref="UpdateTestSuiteTestChatDto" /> class.
        /// </summary>
        /// <param name="scorers">
        /// These are the scorers used to evaluate the test.
        /// </param>
        /// <param name="type">
        /// This is the type of the test, which must be chat.
        /// </param>
        /// <param name="name">
        /// This is the name of the test.
        /// </param>
        /// <param name="script">
        /// This is the script to be used for the chat test.
        /// </param>
        /// <param name="numAttempts">
        /// This is the number of attempts allowed for the test.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTestSuiteTestChatDto(
            global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI>? scorers,
            global::G.UpdateTestSuiteTestChatDtoType? type,
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
        /// Initializes a new instance of the <see cref="UpdateTestSuiteTestChatDto" /> class.
        /// </summary>
        public UpdateTestSuiteTestChatDto()
        {
        }
    }
}