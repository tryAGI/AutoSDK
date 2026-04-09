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
        [global::Newtonsoft.Json.JsonProperty("scorers")]
        public global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI>? Scorers { get; set; }

        /// <summary>
        /// This is the type of the test, which must be chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateTestSuiteTestChatDtoTypeJsonConverter))]
        public global::G.UpdateTestSuiteTestChatDtoType? Type { get; set; }

        /// <summary>
        /// This is the name of the test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the script to be used for the chat test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script")]
        public string? Script { get; set; }

        /// <summary>
        /// This is the number of attempts allowed for the test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numAttempts")]
        public double? NumAttempts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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