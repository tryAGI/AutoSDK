//HintName: G.Models.CreateChannelStreamScheduleSegmentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChannelStreamScheduleSegmentResponse
    {
        /// <summary>
        /// The broadcaster’s streaming scheduled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateChannelStreamScheduleSegmentResponseData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelStreamScheduleSegmentResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The broadcaster’s streaming scheduled.
        /// </param>
        public CreateChannelStreamScheduleSegmentResponse(
            global::G.CreateChannelStreamScheduleSegmentResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelStreamScheduleSegmentResponse" /> class.
        /// </summary>
        public CreateChannelStreamScheduleSegmentResponse()
        {
        }
    }
}