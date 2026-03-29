//HintName: G.Models.SessionLogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionLogResponse
    {
        /// <summary>
        /// milliseconds that have elapsed since the UNIX epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawBody")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLogResponse" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="rawBody"></param>
        /// <param name="timestamp">
        /// milliseconds that have elapsed since the UNIX epoch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionLogResponse(
            object result,
            string rawBody,
            long? timestamp)
        {
            this.Timestamp = timestamp;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.RawBody = rawBody ?? throw new global::System.ArgumentNullException(nameof(rawBody));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLogResponse" /> class.
        /// </summary>
        public SessionLogResponse()
        {
        }
    }
}