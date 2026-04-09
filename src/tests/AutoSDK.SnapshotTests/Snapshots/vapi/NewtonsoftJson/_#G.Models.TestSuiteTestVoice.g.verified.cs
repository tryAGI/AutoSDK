//HintName: G.Models.TestSuiteTestVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteTestVoice
    {
        /// <summary>
        /// These are the scorers used to evaluate the test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI> Scorers { get; set; } = default!;

        /// <summary>
        /// This is the type of the test, which must be voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TestSuiteTestVoiceTypeJsonConverter))]
        public global::G.TestSuiteTestVoiceType Type { get; set; }

        /// <summary>
        /// This is the unique identifier for the test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the test suite this test belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testSuiteId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestSuiteId { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the organization this test belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the name of the test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the script to be used for the voice test.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script", Required = global::Newtonsoft.Json.Required.Always)]
        public string Script { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="TestSuiteTestVoice" /> class.
        /// </summary>
        /// <param name="scorers">
        /// These are the scorers used to evaluate the test.
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the test.
        /// </param>
        /// <param name="testSuiteId">
        /// This is the unique identifier for the test suite this test belongs to.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the organization this test belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the test was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the test was last updated.
        /// </param>
        /// <param name="script">
        /// This is the script to be used for the voice test.
        /// </param>
        /// <param name="type">
        /// This is the type of the test, which must be voice.
        /// </param>
        /// <param name="name">
        /// This is the name of the test.
        /// </param>
        /// <param name="numAttempts">
        /// This is the number of attempts allowed for the test.
        /// </param>
        public TestSuiteTestVoice(
            global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI> scorers,
            string id,
            string testSuiteId,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string script,
            global::G.TestSuiteTestVoiceType type,
            string? name,
            double? numAttempts)
        {
            this.Scorers = scorers ?? throw new global::System.ArgumentNullException(nameof(scorers));
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TestSuiteId = testSuiteId ?? throw new global::System.ArgumentNullException(nameof(testSuiteId));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.Script = script ?? throw new global::System.ArgumentNullException(nameof(script));
            this.NumAttempts = numAttempts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestVoice" /> class.
        /// </summary>
        public TestSuiteTestVoice()
        {
        }
    }
}