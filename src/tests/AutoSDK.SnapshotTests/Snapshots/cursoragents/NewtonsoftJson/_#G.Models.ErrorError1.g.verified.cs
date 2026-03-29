//HintName: G.Models.ErrorError1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorError1
    {
        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Machine-readable error code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
        /// <param name="code">
        /// Machine-readable error code
        /// </param>
        public ErrorError1(
            string? message,
            string? code)
        {
            this.Message = message;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        public ErrorError1()
        {
        }
    }
}