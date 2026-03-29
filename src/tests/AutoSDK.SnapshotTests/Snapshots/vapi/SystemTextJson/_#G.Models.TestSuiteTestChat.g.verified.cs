//HintName: G.Models.TestSuiteTestChat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteTestChat
    {
        /// <summary>
        /// These are the scorers used to evaluate the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI> Scorers { get; set; }

        /// <summary>
        /// This is the type of the test, which must be chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestSuiteTestChatTypeJsonConverter))]
        public global::G.TestSuiteTestChatType Type { get; set; }

        /// <summary>
        /// This is the unique identifier for the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the test suite this test belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testSuiteId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestSuiteId { get; set; }

        /// <summary>
        /// This is the unique identifier for the organization this test belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the name of the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the script to be used for the chat test.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestChat" /> class.
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
        /// This is the script to be used for the chat test.
        /// </param>
        /// <param name="type">
        /// This is the type of the test, which must be chat.
        /// </param>
        /// <param name="name">
        /// This is the name of the test.
        /// </param>
        /// <param name="numAttempts">
        /// This is the number of attempts allowed for the test.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteTestChat(
            global::System.Collections.Generic.IList<global::G.TestSuiteTestScorerAI> scorers,
            string id,
            string testSuiteId,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string script,
            global::G.TestSuiteTestChatType type,
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
        /// Initializes a new instance of the <see cref="TestSuiteTestChat" /> class.
        /// </summary>
        public TestSuiteTestChat()
        {
        }
    }
}