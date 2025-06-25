//HintName: G.Models.EvalRunPerTestingCriteriaResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalRunPerTestingCriteriaResult
    {
        /// <summary>
        /// A description of the testing criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testing_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestingCriteria { get; set; }

        /// <summary>
        /// Number of tests passed for this criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Passed { get; set; }

        /// <summary>
        /// Number of tests failed for this criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunPerTestingCriteriaResult" /> class.
        /// </summary>
        /// <param name="testingCriteria">
        /// A description of the testing criteria.
        /// </param>
        /// <param name="passed">
        /// Number of tests passed for this criteria.
        /// </param>
        /// <param name="failed">
        /// Number of tests failed for this criteria.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRunPerTestingCriteriaResult(
            string testingCriteria,
            int passed,
            int failed)
        {
            this.TestingCriteria = testingCriteria ?? throw new global::System.ArgumentNullException(nameof(testingCriteria));
            this.Passed = passed;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunPerTestingCriteriaResult" /> class.
        /// </summary>
        public EvalRunPerTestingCriteriaResult()
        {
        }
    }
}