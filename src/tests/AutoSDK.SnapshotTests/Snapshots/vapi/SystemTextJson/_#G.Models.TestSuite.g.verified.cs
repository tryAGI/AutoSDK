//HintName: G.Models.TestSuite.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuite
    {
        /// <summary>
        /// This is the unique identifier for the test suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this test suite belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test suite was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the test suite was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the name of the test suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the phone number ID associated with this test suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumberId")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// Override the default tester plan by providing custom assistant configuration for the test agent.<br/>
        /// We recommend only using this if you are confident, as we have already set sensible defaults on the tester plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testerPlan")]
        public global::G.TesterPlan? TesterPlan { get; set; }

        /// <summary>
        /// These are the configuration for the assistant / phone number that is being tested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetPlan")]
        public global::G.TargetPlan? TargetPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuite" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the test suite.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this test suite belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the test suite was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the test suite was last updated.
        /// </param>
        /// <param name="name">
        /// This is the name of the test suite.
        /// </param>
        /// <param name="testerPlan">
        /// Override the default tester plan by providing custom assistant configuration for the test agent.<br/>
        /// We recommend only using this if you are confident, as we have already set sensible defaults on the tester plan.
        /// </param>
        /// <param name="targetPlan">
        /// These are the configuration for the assistant / phone number that is being tested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuite(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            global::G.TesterPlan? testerPlan,
            global::G.TargetPlan? targetPlan)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.TesterPlan = testerPlan;
            this.TargetPlan = targetPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuite" /> class.
        /// </summary>
        public TestSuite()
        {
        }
    }
}