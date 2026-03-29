//HintName: G.Models.UpdateTestCaseDefinitionResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTestCaseDefinitionResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateTestCaseDefinitionResponseStatus3JsonConverter))]
        public global::G.UpdateTestCaseDefinitionResponseStatus3? Status { get; set; }

        /// <summary>
        /// Example: The requested resource was not found.
        /// </summary>
        /// <example>The requested resource was not found.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestCaseDefinitionResponse3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: The requested resource was not found.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTestCaseDefinitionResponse3(
            global::G.UpdateTestCaseDefinitionResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestCaseDefinitionResponse3" /> class.
        /// </summary>
        public UpdateTestCaseDefinitionResponse3()
        {
        }
    }
}