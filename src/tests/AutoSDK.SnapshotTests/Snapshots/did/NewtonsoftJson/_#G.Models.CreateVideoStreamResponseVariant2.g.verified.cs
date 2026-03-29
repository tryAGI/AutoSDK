//HintName: G.Models.CreateVideoStreamResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoStreamResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoStreamResponseVariant2" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="sessionId"></param>
        public CreateVideoStreamResponseVariant2(
            double? duration,
            string? sessionId)
        {
            this.Duration = duration;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoStreamResponseVariant2" /> class.
        /// </summary>
        public CreateVideoStreamResponseVariant2()
        {
        }
    }
}