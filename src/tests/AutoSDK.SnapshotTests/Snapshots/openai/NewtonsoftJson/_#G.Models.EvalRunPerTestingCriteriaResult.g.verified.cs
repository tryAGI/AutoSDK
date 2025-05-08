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
        [global::Newtonsoft.Json.JsonProperty("testing_criteria", Required = global::Newtonsoft.Json.Required.Always)]
        public string TestingCriteria { get; set; } = default!;

        /// <summary>
        /// Number of tests passed for this criteria.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Passed { get; set; } = default!;

        /// <summary>
        /// Number of tests failed for this criteria.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Failed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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