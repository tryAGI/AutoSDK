//HintName: G.Models.GetChannelStreamScheduleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelStreamScheduleResponse
    {
        /// <summary>
        /// The broadcaster’s streaming schedule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetChannelStreamScheduleResponseData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelStreamScheduleResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The broadcaster’s streaming schedule.
        /// </param>
        public GetChannelStreamScheduleResponse(
            global::G.GetChannelStreamScheduleResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelStreamScheduleResponse" /> class.
        /// </summary>
        public GetChannelStreamScheduleResponse()
        {
        }
    }
}