//HintName: G.Models.TestsFeatureUsageCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestsFeatureUsageCommonModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tests_ran_after_last_modification")]
        public bool? TestsRanAfterLastModification { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tests_ran_in_last_7_days")]
        public bool? TestsRanInLast7Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestsFeatureUsageCommonModel" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="testsRanAfterLastModification">
        /// Default Value: false
        /// </param>
        /// <param name="testsRanInLast7Days">
        /// Default Value: false
        /// </param>
        public TestsFeatureUsageCommonModel(
            bool? enabled,
            bool? testsRanAfterLastModification,
            bool? testsRanInLast7Days)
        {
            this.Enabled = enabled;
            this.TestsRanAfterLastModification = testsRanAfterLastModification;
            this.TestsRanInLast7Days = testsRanInLast7Days;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestsFeatureUsageCommonModel" /> class.
        /// </summary>
        public TestsFeatureUsageCommonModel()
        {
        }
    }
}