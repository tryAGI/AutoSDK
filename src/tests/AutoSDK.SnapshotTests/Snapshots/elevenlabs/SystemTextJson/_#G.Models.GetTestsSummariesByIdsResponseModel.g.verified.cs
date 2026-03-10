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
        [global::System.Text.Json.Serialization.JsonPropertyName("tests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.UnitTestSummaryResponseModel> Tests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestsSummariesByIdsResponseModel" /> class.
        /// </summary>
        /// <param name="tests">
        /// Dictionary mapping test IDs to their summary information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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