//HintName: G.Models.Request11.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request11
    {
        /// <summary>
        /// The start date of the usage data in ISO-8601 format (YYYY-MM-DD). If unspecified, it will default to 30 days before the current date. All dates are in UTC.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the usage data in ISO-8601 format (YYYY-MM-DD), not inclusive. If unspecified, it will default to thirty days after the start date. Must be less than or equal to 90 days after the start date. All dates are in UTC.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("beforeDate")]
        public global::System.DateTime? BeforeDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request11" /> class.
        /// </summary>
        /// <param name="startDate">
        /// The start date of the usage data in ISO-8601 format (YYYY-MM-DD). If unspecified, it will default to 30 days before the current date. All dates are in UTC.
        /// </param>
        /// <param name="beforeDate">
        /// The end date of the usage data in ISO-8601 format (YYYY-MM-DD), not inclusive. If unspecified, it will default to thirty days after the start date. Must be less than or equal to 90 days after the start date. All dates are in UTC.
        /// </param>
        public Request11(
            global::System.DateTime? startDate,
            global::System.DateTime? beforeDate)
        {
            this.StartDate = startDate;
            this.BeforeDate = beforeDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request11" /> class.
        /// </summary>
        public Request11()
        {
        }
    }
}