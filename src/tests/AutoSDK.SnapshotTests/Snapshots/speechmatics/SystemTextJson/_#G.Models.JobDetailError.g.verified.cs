//HintName: G.Models.JobDetailError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobDetailError
    {
        /// <summary>
        /// Example: 2021-07-14 11:53:49.242000+00:00
        /// </summary>
        /// <example>2021-07-14 11:53:49.242000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Example: Audio fetch error, http status 418
        /// </summary>
        /// <example>Audio fetch error, http status 418</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDetailError" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Example: 2021-07-14 11:53:49.242000+00:00
        /// </param>
        /// <param name="message">
        /// Example: Audio fetch error, http status 418
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobDetailError(
            string timestamp,
            string message)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDetailError" /> class.
        /// </summary>
        public JobDetailError()
        {
        }
    }
}