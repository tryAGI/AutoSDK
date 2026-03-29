//HintName: G.Models.CreateIndexedAssetRequestNotFoundError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIndexedAssetRequestNotFoundError
    {
        /// <summary>
        /// Represents the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable string describing the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIndexedAssetRequestNotFoundError" /> class.
        /// </summary>
        /// <param name="code">
        /// Represents the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </param>
        /// <param name="message">
        /// A human-readable string describing the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIndexedAssetRequestNotFoundError(
            string? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIndexedAssetRequestNotFoundError" /> class.
        /// </summary>
        public CreateIndexedAssetRequestNotFoundError()
        {
        }
    }
}