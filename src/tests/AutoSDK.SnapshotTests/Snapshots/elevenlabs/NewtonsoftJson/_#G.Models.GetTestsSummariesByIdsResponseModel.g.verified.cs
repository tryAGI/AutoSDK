//HintName: G.Models.GetTestsSummariesByIdsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTestsSummariesByIdsResponseModel
    {
        /// <summary>
        /// Dictionary mapping test IDs to their summary information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.UnitTestSummaryResponseModel> Tests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestsSummariesByIdsResponseModel" /> class.
        /// </summary>
        /// <param name="tests">
        /// Dictionary mapping test IDs to their summary information
        /// </param>
        public GetTestsSummariesByIdsResponseModel(
            global::System.Collections.Generic.Dictionary<string, global::G.UnitTestSummaryResponseModel> tests)
        {
            this.Tests = tests ?? throw new global::System.ArgumentNullException(nameof(tests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestsSummariesByIdsResponseModel" /> class.
        /// </summary>
        public GetTestsSummariesByIdsResponseModel()
        {
        }
    }
}