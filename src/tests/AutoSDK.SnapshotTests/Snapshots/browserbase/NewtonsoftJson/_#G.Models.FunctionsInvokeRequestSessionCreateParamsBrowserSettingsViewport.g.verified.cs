//HintName: G.Models.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport
    {
        /// <summary>
        /// The width of the browser.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height of the browser.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport" /> class.
        /// </summary>
        /// <param name="width">
        /// The width of the browser.
        /// </param>
        /// <param name="height">
        /// The height of the browser.
        /// </param>
        public FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport(
            int? width,
            int? height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport" /> class.
        /// </summary>
        public FunctionsInvokeRequestSessionCreateParamsBrowserSettingsViewport()
        {
        }
    }
}