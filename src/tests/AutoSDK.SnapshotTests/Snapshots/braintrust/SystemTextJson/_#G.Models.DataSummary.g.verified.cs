//HintName: G.Models.DataSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of a dataset's data
    /// </summary>
    public sealed partial class DataSummary
    {
        /// <summary>
        /// Total number of records in the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_records")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSummary" /> class.
        /// </summary>
        /// <param name="totalRecords">
        /// Total number of records in the dataset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSummary(
            int totalRecords)
        {
            this.TotalRecords = totalRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSummary" /> class.
        /// </summary>
        public DataSummary()
        {
        }
    }
}