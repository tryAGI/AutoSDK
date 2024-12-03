//HintName: G.Models.GetShieldModeStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetShieldModeStatusResponse
    {
        /// <summary>
        /// A list that contains a single object with the broadcaster’s Shield Mode status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetShieldModeStatusResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetShieldModeStatusResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains a single object with the broadcaster’s Shield Mode status.
        /// </param>
        public GetShieldModeStatusResponse(
            global::System.Collections.Generic.IList<global::G.GetShieldModeStatusResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetShieldModeStatusResponse" /> class.
        /// </summary>
        public GetShieldModeStatusResponse()
        {
        }
    }
}