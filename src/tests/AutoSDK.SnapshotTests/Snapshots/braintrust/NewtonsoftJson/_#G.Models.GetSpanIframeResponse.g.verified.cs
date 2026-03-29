//HintName: G.Models.GetSpanIframeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpanIframeResponse
    {
        /// <summary>
        /// A list of span_iframe objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SpanIFrame> Objects { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpanIframeResponse" /> class.
        /// </summary>
        /// <param name="objects">
        /// A list of span_iframe objects
        /// </param>
        public GetSpanIframeResponse(
            global::System.Collections.Generic.IList<global::G.SpanIFrame> objects)
        {
            this.Objects = objects ?? throw new global::System.ArgumentNullException(nameof(objects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpanIframeResponse" /> class.
        /// </summary>
        public GetSpanIframeResponse()
        {
        }
    }
}