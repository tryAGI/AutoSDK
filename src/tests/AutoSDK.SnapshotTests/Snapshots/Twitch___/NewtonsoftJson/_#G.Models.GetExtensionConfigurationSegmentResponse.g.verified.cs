//HintName: G.Models.GetExtensionConfigurationSegmentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExtensionConfigurationSegmentResponse
    {
        /// <summary>
        /// The list of requested configuration segments. The list is returned in the same order that you specified the list of segments in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExtensionConfigurationSegment> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionConfigurationSegmentResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of requested configuration segments. The list is returned in the same order that you specified the list of segments in the request.
        /// </param>
        public GetExtensionConfigurationSegmentResponse(
            global::System.Collections.Generic.IList<global::G.ExtensionConfigurationSegment> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionConfigurationSegmentResponse" /> class.
        /// </summary>
        public GetExtensionConfigurationSegmentResponse()
        {
        }
    }
}