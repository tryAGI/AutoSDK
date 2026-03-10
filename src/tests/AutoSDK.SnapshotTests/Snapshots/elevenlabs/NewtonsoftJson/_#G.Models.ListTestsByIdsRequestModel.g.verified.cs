//HintName: G.Models.ListTestsByIdsRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTestsByIdsRequestModel
    {
        /// <summary>
        /// List of test IDs to fetch. No duplicates allowed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TestIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTestsByIdsRequestModel" /> class.
        /// </summary>
        /// <param name="testIds">
        /// List of test IDs to fetch. No duplicates allowed.
        /// </param>
        public ListTestsByIdsRequestModel(
            global::System.Collections.Generic.IList<string> testIds)
        {
            this.TestIds = testIds ?? throw new global::System.ArgumentNullException(nameof(testIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTestsByIdsRequestModel" /> class.
        /// </summary>
        public ListTestsByIdsRequestModel()
        {
        }
    }
}