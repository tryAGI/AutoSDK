//HintName: G.Models.FeedbackResponseSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackResponseSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FeedbackResponseSchemaStatusJsonConverter))]
        public global::G.FeedbackResponseSchemaStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponseSchema" /> class.
        /// </summary>
        /// <param name="status"></param>
        public FeedbackResponseSchema(
            global::G.FeedbackResponseSchemaStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponseSchema" /> class.
        /// </summary>
        public FeedbackResponseSchema()
        {
        }
    }
}