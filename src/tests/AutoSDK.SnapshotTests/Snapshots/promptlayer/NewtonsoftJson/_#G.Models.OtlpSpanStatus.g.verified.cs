//HintName: G.Models.OtlpSpanStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Span status.
    /// </summary>
    public sealed partial class OtlpSpanStatus
    {
        /// <summary>
        /// Status code: 0=UNSET, 1=OK, 2=ERROR.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Status message (typically set for ERROR status).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpSpanStatus" /> class.
        /// </summary>
        /// <param name="code">
        /// Status code: 0=UNSET, 1=OK, 2=ERROR.
        /// </param>
        /// <param name="message">
        /// Status message (typically set for ERROR status).
        /// </param>
        public OtlpSpanStatus(
            int? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpSpanStatus" /> class.
        /// </summary>
        public OtlpSpanStatus()
        {
        }
    }
}