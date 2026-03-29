//HintName: G.Models.TestSuiteRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRun
    {
        /// <summary>
        /// This is the current status of the test suite run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestSuiteRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestSuiteRunStatus Status { get; set; }

        /// <summary>
        /// This is the unique identifier for the test suite run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the organization this run belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the unique identifier for the test suite this run belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testSuiteId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestSuiteId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test suite run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test suite run was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// These are the results of the tests in this test suite run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testResults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TestSuiteRunTestResult> TestResults { get; set; }

        /// <summary>
        /// This is the name of the test suite run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRun" /> class.
        /// </summary>
        /// <param name="status">
        /// This is the current status of the test suite run.
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the test suite run.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the organization this run belongs to.
        /// </param>
        /// <param name="testSuiteId">
        /// This is the unique identifier for the test suite this run belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the test suite run was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the test suite run was last updated.
        /// </param>
        /// <param name="testResults">
        /// These are the results of the tests in this test suite run.
        /// </param>
        /// <param name="name">
        /// This is the name of the test suite run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRun(
            global::G.TestSuiteRunStatus status,
            string id,
            string orgId,
            string testSuiteId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::G.TestSuiteRunTestResult> testResults,
            string? name)
        {
            this.Status = status;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.TestSuiteId = testSuiteId ?? throw new global::System.ArgumentNullException(nameof(testSuiteId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TestResults = testResults ?? throw new global::System.ArgumentNullException(nameof(testResults));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRun" /> class.
        /// </summary>
        public TestSuiteRun()
        {
        }
    }
}