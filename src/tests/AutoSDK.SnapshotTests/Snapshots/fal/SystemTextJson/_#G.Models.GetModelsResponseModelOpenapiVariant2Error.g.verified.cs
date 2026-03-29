//HintName: G.Models.GetModelsResponseModelOpenapiVariant2Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error details for failed OpenAPI expansion
    /// </summary>
    public sealed partial class GetModelsResponseModelOpenapiVariant2Error
    {
        /// <summary>
        /// Error code (e.g., 'expansion_failed')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelOpenapiVariant2Error" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code (e.g., 'expansion_failed')
        /// </param>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsResponseModelOpenapiVariant2Error(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModelOpenapiVariant2Error" /> class.
        /// </summary>
        public GetModelsResponseModelOpenapiVariant2Error()
        {
        }
    }
}