//HintName: G.Models.AddKnowledgeBaseSourcesResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddKnowledgeBaseSourcesResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AddKnowledgeBaseSourcesResponseStatus3JsonConverter))]
        public global::G.AddKnowledgeBaseSourcesResponseStatus3? Status { get; set; }

        /// <summary>
        /// Example: Trial has ended, please add payment method.
        /// </summary>
        /// <example>Trial has ended, please add payment method.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddKnowledgeBaseSourcesResponse3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Trial has ended, please add payment method.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddKnowledgeBaseSourcesResponse3(
            global::G.AddKnowledgeBaseSourcesResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddKnowledgeBaseSourcesResponse3" /> class.
        /// </summary>
        public AddKnowledgeBaseSourcesResponse3()
        {
        }
    }
}