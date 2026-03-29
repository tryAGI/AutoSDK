//HintName: G.Models.AddReportColumnResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddReportColumnResponse4
    {
        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Example: Report not found
        /// </summary>
        /// <example>Report not found</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddReportColumnResponse4" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: false
        /// </param>
        /// <param name="message">
        /// Example: Report not found
        /// </param>
        public AddReportColumnResponse4(
            bool? success,
            string? message)
        {
            this.Success = success;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddReportColumnResponse4" /> class.
        /// </summary>
        public AddReportColumnResponse4()
        {
        }
    }
}