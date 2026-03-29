//HintName: G.Models.SpanStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StatusCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StatusCode StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanStatus" /> class.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpanStatus(
            global::G.StatusCode statusCode,
            string? description)
        {
            this.StatusCode = statusCode;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanStatus" /> class.
        /// </summary>
        public SpanStatus()
        {
        }
    }
}