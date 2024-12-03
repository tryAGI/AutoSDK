//HintName: G.Models.GetUserActiveExtensionsResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The active extensions that the broadcaster has installed.
    /// </summary>
    public sealed partial class GetUserActiveExtensionsResponseData
    {
        /// <summary>
        /// A dictionary that contains the data for a panel extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the panel’s data for each key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel")]
        public global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionPanel>? Panel { get; set; }

        /// <summary>
        /// A dictionary that contains the data for a video-overlay extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the overlay’s data for each key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlay")]
        public global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionOverlay>? Overlay { get; set; }

        /// <summary>
        /// A dictionary that contains the data for a video-component extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the component’s data for each key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        public global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionComponent>? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserActiveExtensionsResponseData" /> class.
        /// </summary>
        /// <param name="panel">
        /// A dictionary that contains the data for a panel extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the panel’s data for each key.
        /// </param>
        /// <param name="overlay">
        /// A dictionary that contains the data for a video-overlay extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the overlay’s data for each key.
        /// </param>
        /// <param name="component">
        /// A dictionary that contains the data for a video-component extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the component’s data for each key.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetUserActiveExtensionsResponseData(
            global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionPanel>? panel,
            global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionOverlay>? overlay,
            global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionComponent>? component)
        {
            this.Panel = panel;
            this.Overlay = overlay;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserActiveExtensionsResponseData" /> class.
        /// </summary>
        public GetUserActiveExtensionsResponseData()
        {
        }
    }
}