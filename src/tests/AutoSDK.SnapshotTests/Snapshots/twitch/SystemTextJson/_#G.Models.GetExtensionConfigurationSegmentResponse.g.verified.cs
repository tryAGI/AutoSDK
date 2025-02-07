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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExtensionConfigurationSegment> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionConfigurationSegmentResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of requested configuration segments. The list is returned in the same order that you specified the list of segments in the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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