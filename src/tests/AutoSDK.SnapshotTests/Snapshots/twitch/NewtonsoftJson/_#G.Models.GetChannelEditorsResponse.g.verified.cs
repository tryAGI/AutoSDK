//HintName: G.Models.GetChannelEditorsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelEditorsResponse
    {
        /// <summary>
        /// A list of users that are editors for the specified broadcaster. The list is empty if the broadcaster doesn’t have editors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChannelEditor> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelEditorsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of users that are editors for the specified broadcaster. The list is empty if the broadcaster doesn’t have editors.
        /// </param>
        public GetChannelEditorsResponse(
            global::System.Collections.Generic.IList<global::G.ChannelEditor> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelEditorsResponse" /> class.
        /// </summary>
        public GetChannelEditorsResponse()
        {
        }
    }
}