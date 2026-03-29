//HintName: G.Models.CreateTestSuiteTestChatDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTestSuiteTestChatDto
    {
        /// <summary>
        /// These are the scorers used to evaluate the test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI> Scorers { get; set; } = default!;

        /// <summary>
        /// This is the type of the test, which must be chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateTestSuiteTestChatDtoType Type { get; set; }

        /// <summary>
        /// This is the script to be used for the chat test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script", Required = global::Newtonsoft.Json.Required.Always)]
        public string Script { get; set; } = default!;

        /// <summary>
        /// This is the number of attempts allowed for the test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numAttempts")]
        public double? NumAttempts { get; set; }

        /// <summary>
        /// This is the name of the test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTestSuiteTestChatDto" /> class.
        /// </summary>
        /// <param name="scorers">
        /// These are the scorers used to evaluate the test.
        /// </param>
        /// <param name="script">
        /// This is the script to be used for the chat test.
        /// </param>
        /// <param name="type">
        /// This is the type of the test, which must be chat.
        /// </param>
        /// <param name="numAttempts">
        /// This is the number of attempts allowed for the test.
        /// </param>
        /// <param name="name">
        /// This is the name of the test.
        /// </param>
        public CreateTestSuiteTestChatDto(
            global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI> scorers,
            string script,
            global::G.CreateTestSuiteTestChatDtoType type,
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
        /// Initializes a new instance of the <see cref="CreateTestSuiteTestChatDto" /> class.
        /// </summary>
        public CreateTestSuiteTestChatDto()
        {
        }
    }
}