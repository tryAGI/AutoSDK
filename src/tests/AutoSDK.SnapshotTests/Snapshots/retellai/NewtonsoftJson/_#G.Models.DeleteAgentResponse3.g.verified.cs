//HintName: G.Models.DeleteAgentResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAgentResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.DeleteAgentResponseStatus3? Status { get; set; }

        /// <summary>
        /// Example: Cannot find requested asset under given api key.
        /// </summary>
        /// <example>Cannot find requested asset under given api key.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAgentResponse3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Cannot find requested asset under given api key.
        /// </param>
        public DeleteAgentResponse3(
            global::G.DeleteAgentResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAgentResponse3" /> class.
        /// </summary>
        public DeleteAgentResponse3()
        {
        }
    }
}