//HintName: G.Models.UpdateTestSuiteDto.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTestSuiteDto
    {
        /// <summary>
        /// This is the name of the test suite.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the phone number ID associated with this test suite.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumberId")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// Override the default tester plan by providing custom assistant configuration for the test agent.<br/>
        /// We recommend only using this if you are confident, as we have already set sensible defaults on the tester plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testerPlan")]
        public global::G.TesterPlan? TesterPlan { get; set; }

        /// <summary>
        /// These are the configuration for the assistant / phone number that is being tested.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("targetPlan")]
        public global::G.TargetPlan? TargetPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestSuiteDto" /> class.
        /// </summary>
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
        public UpdateTestSuiteDto(
            string? name,
            global::G.TesterPlan? testerPlan,
            global::G.TargetPlan? targetPlan)
        {
            this.Name = name;
            this.TesterPlan = testerPlan;
            this.TargetPlan = targetPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestSuiteDto" /> class.
        /// </summary>
        public UpdateTestSuiteDto()
        {
        }
    }
}