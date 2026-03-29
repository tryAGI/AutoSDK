//HintName: G.Models.AddReportColumnResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddReportColumnResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Details of the created column including its ID and configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("report_column")]
        public object? ReportColumn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddReportColumnResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: true
        /// </param>
        /// <param name="reportColumn">
        /// Details of the created column including its ID and configuration
        /// </param>
        public AddReportColumnResponse(
            bool? success,
            object? reportColumn)
        {
            this.Success = success;
            this.ReportColumn = reportColumn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddReportColumnResponse" /> class.
        /// </summary>
        public AddReportColumnResponse()
        {
        }
    }
}