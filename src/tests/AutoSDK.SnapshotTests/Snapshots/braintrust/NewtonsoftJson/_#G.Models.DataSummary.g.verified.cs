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
        [global::Newtonsoft.Json.JsonProperty("total_records", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalRecords { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSummary" /> class.
        /// </summary>
        /// <param name="totalRecords">
        /// Total number of records in the dataset
        /// </param>
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