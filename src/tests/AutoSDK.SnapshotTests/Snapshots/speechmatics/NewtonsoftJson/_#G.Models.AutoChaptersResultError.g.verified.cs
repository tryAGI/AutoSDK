//HintName: G.Models.AutoChaptersResultError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoChaptersResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AutoChaptersResultErrorTypeJsonConverter))]
        public global::G.AutoChaptersResultErrorType? Type { get; set; }

        /// <summary>
        /// Human readable error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoChaptersResultError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Human readable error message
        /// </param>
        public AutoChaptersResultError(
            global::G.AutoChaptersResultErrorType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoChaptersResultError" /> class.
        /// </summary>
        public AutoChaptersResultError()
        {
        }
    }
}