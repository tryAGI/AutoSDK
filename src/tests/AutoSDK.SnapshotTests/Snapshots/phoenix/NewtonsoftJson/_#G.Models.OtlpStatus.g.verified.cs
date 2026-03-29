//HintName: G.Models.OtlpStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtlpStatus
    {
        /// <summary>
        /// The status code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// A developer-facing human readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpStatus" /> class.
        /// </summary>
        /// <param name="code">
        /// The status code.
        /// </param>
        /// <param name="message">
        /// A developer-facing human readable error message.
        /// </param>
        public OtlpStatus(
            int? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpStatus" /> class.
        /// </summary>
        public OtlpStatus()
        {
        }
    }
}