//HintName: G.Models.FeedbackSource3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The feedback source loaded from the database.
    /// </summary>
    public sealed partial class FeedbackSource3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackSource3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="userId"></param>
        public FeedbackSource3(
            string? type,
            object? metadata,
            global::System.Guid? userId)
        {
            this.Type = type;
            this.Metadata = metadata;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackSource3" /> class.
        /// </summary>
        public FeedbackSource3()
        {
        }
    }
}