﻿//HintName: G.Models.UpdateUserExtensionsResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The extensions that the broadcaster updated.
    /// </summary>
    public sealed partial class UpdateUserExtensionsResponseData
    {
        /// <summary>
        /// A dictionary that contains the data for a panel extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the panel’s data for each key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("panel", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionPanel> Panel { get; set; } = default!;

        /// <summary>
        /// A dictionary that contains the data for a video-overlay extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the overlay’s data for each key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overlay", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionOverlay> Overlay { get; set; } = default!;

        /// <summary>
        /// A dictionary that contains the data for a video-component extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the component’s data for each key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionComponent> Component { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserExtensionsResponseData" /> class.
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
        public UpdateUserExtensionsResponseData(
            global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionPanel> panel,
            global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionOverlay> overlay,
            global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionComponent> component)
        {
            this.Panel = panel ?? throw new global::System.ArgumentNullException(nameof(panel));
            this.Overlay = overlay ?? throw new global::System.ArgumentNullException(nameof(overlay));
            this.Component = component ?? throw new global::System.ArgumentNullException(nameof(component));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserExtensionsResponseData" /> class.
        /// </summary>
        public UpdateUserExtensionsResponseData()
        {
        }
    }
}