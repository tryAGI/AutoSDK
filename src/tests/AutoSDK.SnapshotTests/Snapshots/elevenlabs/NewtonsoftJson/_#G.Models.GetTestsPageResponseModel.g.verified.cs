//HintName: G.Models.GetTestsPageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTestsPageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UnitTestSummaryResponseModel> Tests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestsPageResponseModel" /> class.
        /// </summary>
        /// <param name="tests"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
        public GetTestsPageResponseModel(
            global::System.Collections.Generic.IList<global::G.UnitTestSummaryResponseModel> tests,
            bool hasMore,
            string? nextCursor)
        {
            this.Tests = tests ?? throw new global::System.ArgumentNullException(nameof(tests));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestsPageResponseModel" /> class.
        /// </summary>
        public GetTestsPageResponseModel()
        {
        }
    }
}