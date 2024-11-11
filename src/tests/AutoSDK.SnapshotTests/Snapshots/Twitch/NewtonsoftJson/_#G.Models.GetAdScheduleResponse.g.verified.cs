//HintName: G.Models.GetAdScheduleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAdScheduleResponse
    {
        /// <summary>
        /// A list that contains information related to the channel’s ad schedule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetAdScheduleResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAdScheduleResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains information related to the channel’s ad schedule.
        /// </param>
        public GetAdScheduleResponse(
            global::System.Collections.Generic.IList<global::G.GetAdScheduleResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAdScheduleResponse" /> class.
        /// </summary>
        public GetAdScheduleResponse()
        {
        }
    }
}