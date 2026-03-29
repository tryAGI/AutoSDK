//HintName: G.Models.GetDeepResearchStatusResponseDataActivitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeepResearchStatusResponseDataActivitie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeepResearchStatusResponseDataActivitie" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <param name="depth"></param>
        public GetDeepResearchStatusResponseDataActivitie(
            string? type,
            string? status,
            string? message,
            global::System.DateTime? timestamp,
            int? depth)
        {
            this.Type = type;
            this.Status = status;
            this.Message = message;
            this.Timestamp = timestamp;
            this.Depth = depth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeepResearchStatusResponseDataActivitie" /> class.
        /// </summary>
        public GetDeepResearchStatusResponseDataActivitie()
        {
        }
    }
}