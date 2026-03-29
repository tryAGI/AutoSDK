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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestSuiteRunStatus Status { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the test suite run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the organization this run belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the test suite this run belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testSuiteId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestSuiteId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test suite run was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test suite run was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// These are the results of the tests in this test suite run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testResults", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TestSuiteRunTestResult> TestResults { get; set; } = default!;

        /// <summary>
        /// This is the name of the test suite run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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