//HintName: G.Models.TopicDetectionError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicDetectionError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TopicDetectionErrorTypeJsonConverter))]
        public global::G.TopicDetectionErrorType? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="TopicDetectionError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Human readable error message
        /// </param>
        public TopicDetectionError(
            global::G.TopicDetectionErrorType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionError" /> class.
        /// </summary>
        public TopicDetectionError()
        {
        }
    }
}