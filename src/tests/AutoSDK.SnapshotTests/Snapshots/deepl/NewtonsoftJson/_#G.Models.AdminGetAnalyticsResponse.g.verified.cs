//HintName: G.Models.AdminGetAnalyticsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminGetAnalyticsResponse
    {
        /// <summary>
        /// Error message describing the issue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminGetAnalyticsResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Error message describing the issue.
        /// </param>
        public AdminGetAnalyticsResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminGetAnalyticsResponse" /> class.
        /// </summary>
        public AdminGetAnalyticsResponse()
        {
        }
    }
}