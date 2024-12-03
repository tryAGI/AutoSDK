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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetChannelStreamScheduleResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelStreamScheduleResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The broadcaster’s streaming schedule.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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