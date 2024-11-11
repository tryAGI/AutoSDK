//HintName: G.Models.GetChannelInformationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelInformationResponse
    {
        /// <summary>
        /// A list that contains information about the specified channels. The list is empty if the specified channels weren’t found.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChannelInformation> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelInformationResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains information about the specified channels. The list is empty if the specified channels weren’t found.
        /// </param>
        public GetChannelInformationResponse(
            global::System.Collections.Generic.IList<global::G.ChannelInformation> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelInformationResponse" /> class.
        /// </summary>
        public GetChannelInformationResponse()
        {
        }
    }
}