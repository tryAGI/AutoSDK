//HintName: G.Models.RunObjectLastError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The last error associated with this run. Will be `null` if there are no errors.
    /// </summary>
    public sealed partial class RunObjectLastError
    {
        /// <summary>
        /// One of `server_error`, `rate_limit_exceeded`, or `invalid_prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RunObjectLastErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RunObjectLastErrorCode Code { get; set; }

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