//HintName: G.Models.VectorStoreFileObjectLastError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The last error associated with this vector store file. Will be `null` if there are no errors.
    /// </summary>
    public sealed partial class VectorStoreFileObjectLastError
    {
        /// <summary>
        /// One of `server_error` or `rate_limit_exceeded`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable description of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}