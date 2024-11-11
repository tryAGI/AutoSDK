//HintName: G.Models.UpdateShieldModeStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateShieldModeStatusResponse
    {
        /// <summary>
        /// A list that contains a single object with the broadcaster’s updated Shield Mode status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UpdateShieldModeStatusResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShieldModeStatusResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains a single object with the broadcaster’s updated Shield Mode status.
        /// </param>
        public UpdateShieldModeStatusResponse(
            global::System.Collections.Generic.IList<global::G.UpdateShieldModeStatusResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateShieldModeStatusResponse" /> class.
        /// </summary>
        public UpdateShieldModeStatusResponse()
        {
        }
    }
}