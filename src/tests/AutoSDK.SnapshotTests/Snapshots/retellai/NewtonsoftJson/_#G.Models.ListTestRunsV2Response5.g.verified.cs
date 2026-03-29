//HintName: G.Models.ListTestRunsV2Response5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTestRunsV2Response5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ListTestRunsV2ResponseStatus3? Status { get; set; }

        /// <summary>
        /// Example: The requested resource was not found.
        /// </summary>
        /// <example>The requested resource was not found.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTestRunsV2Response5" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: The requested resource was not found.
        /// </param>
        public ListTestRunsV2Response5(
            global::G.ListTestRunsV2ResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTestRunsV2Response5" /> class.
        /// </summary>
        public ListTestRunsV2Response5()
        {
        }
    }
}