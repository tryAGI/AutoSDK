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
        [global::System.Text.Json.Serialization.JsonPropertyName("test_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TestIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTestsByIdsRequestModel" /> class.
        /// </summary>
        /// <param name="testIds">
        /// List of test IDs to fetch. No duplicates allowed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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