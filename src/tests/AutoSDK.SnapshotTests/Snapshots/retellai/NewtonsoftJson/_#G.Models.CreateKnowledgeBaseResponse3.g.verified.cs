//HintName: G.Models.CreateKnowledgeBaseResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKnowledgeBaseResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.CreateKnowledgeBaseResponseStatus3? Status { get; set; }

        /// <summary>
        /// Example: Trial has ended, please add payment method.
        /// </summary>
        /// <example>Trial has ended, please add payment method.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeBaseResponse3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Trial has ended, please add payment method.
        /// </param>
        public CreateKnowledgeBaseResponse3(
            global::G.CreateKnowledgeBaseResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeBaseResponse3" /> class.
        /// </summary>
        public CreateKnowledgeBaseResponse3()
        {
        }
    }
}