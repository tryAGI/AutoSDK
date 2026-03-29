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
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StatusCode StatusCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanStatus" /> class.
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="description"></param>
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