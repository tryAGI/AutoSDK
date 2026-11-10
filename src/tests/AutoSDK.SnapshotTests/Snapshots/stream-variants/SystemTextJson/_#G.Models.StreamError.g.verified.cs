//HintName: G.Models.StreamError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_after")]
        public int? RetryAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="retryAfter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamError(
            string code,
            int? retryAfter)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.RetryAfter = retryAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamError" /> class.
        /// </summary>
        public StreamError()
        {
        }

    }
}