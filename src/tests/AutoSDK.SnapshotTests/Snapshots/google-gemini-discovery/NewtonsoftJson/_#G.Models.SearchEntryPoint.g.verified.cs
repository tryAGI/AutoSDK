//HintName: G.Models.SearchEntryPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Google search entry point.
    /// </summary>
    public sealed partial class SearchEntryPoint
    {
        /// <summary>
        /// Optional. Web content snippet that can be embedded in a web page or an app webview.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("renderedContent")]
        public string? RenderedContent { get; set; }

        /// <summary>
        /// Optional. Base64 encoded JSON representing array of tuple.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdkBlob")]
        public byte[]? SdkBlob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEntryPoint" /> class.
        /// </summary>
        /// <param name="renderedContent">
        /// Optional. Web content snippet that can be embedded in a web page or an app webview.
        /// </param>
        /// <param name="sdkBlob">
        /// Optional. Base64 encoded JSON representing array of tuple.
        /// </param>
        public SearchEntryPoint(
            string? renderedContent,
            byte[]? sdkBlob)
        {
            this.RenderedContent = renderedContent;
            this.SdkBlob = sdkBlob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEntryPoint" /> class.
        /// </summary>
        public SearchEntryPoint()
        {
        }
    }
}