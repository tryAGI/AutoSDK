//HintName: G.Models.ListVoicesResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListVoicesResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ListVoicesResponseStatus2? Status { get; set; }

        /// <summary>
        /// Example: An unexpected server error occurred.
        /// </summary>
        /// <example>An unexpected server error occurred.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: An unexpected server error occurred.
        /// </param>
        public ListVoicesResponse2(
            global::G.ListVoicesResponseStatus2? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse2" /> class.
        /// </summary>
        public ListVoicesResponse2()
        {
        }
    }
}