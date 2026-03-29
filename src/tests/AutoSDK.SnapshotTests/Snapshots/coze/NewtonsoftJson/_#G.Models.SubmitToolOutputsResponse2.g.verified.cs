//HintName: G.Models.SubmitToolOutputsResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitToolOutputsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.ChatV3MessageDetail? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.SubmitToolOutputsResponseEvent? Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsResponse2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="event"></param>
        public SubmitToolOutputsResponse2(
            global::G.ChatV3MessageDetail? data,
            global::G.SubmitToolOutputsResponseEvent? @event)
        {
            this.Data = data;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsResponse2" /> class.
        /// </summary>
        public SubmitToolOutputsResponse2()
        {
        }
    }
}