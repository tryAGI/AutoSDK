//HintName: G.Models.DeleteMultilingualGlossaryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteMultilingualGlossaryResponse
    {
        /// <summary>
        /// Generic description of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// More specific description of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMultilingualGlossaryResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Generic description of the error.
        /// </param>
        /// <param name="detail">
        /// More specific description of the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteMultilingualGlossaryResponse(
            string? message,
            string? detail)
        {
            this.Message = message;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMultilingualGlossaryResponse" /> class.
        /// </summary>
        public DeleteMultilingualGlossaryResponse()
        {
        }
    }
}