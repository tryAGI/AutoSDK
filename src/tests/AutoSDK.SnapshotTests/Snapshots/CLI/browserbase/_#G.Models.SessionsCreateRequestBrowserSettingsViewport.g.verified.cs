//HintName: G.Models.SessionsCreateRequestBrowserSettingsViewport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsCreateRequestBrowserSettingsViewport
    {
        /// <summary>
        /// The width of the browser.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height of the browser.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequestBrowserSettingsViewport" /> class.
        /// </summary>
        /// <param name="width">
        /// The width of the browser.
        /// </param>
        /// <param name="height">
        /// The height of the browser.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsCreateRequestBrowserSettingsViewport(
            int? width,
            int? height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequestBrowserSettingsViewport" /> class.
        /// </summary>
        public SessionsCreateRequestBrowserSettingsViewport()
        {
        }
    }
}