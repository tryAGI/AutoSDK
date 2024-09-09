//HintName: G.Models.UpdateUserExtensionsResponseData.g.cs

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
        public global::G.UpdateUserExtensionsResponseDataPanel Panel { get; set; } = default!;

        /// <summary>
        /// A dictionary that contains the data for a video-overlay extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the overlay’s data for each key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overlay", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateUserExtensionsResponseDataOverlay Overlay { get; set; } = default!;

        /// <summary>
        /// A dictionary that contains the data for a video-component extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the component’s data for each key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateUserExtensionsResponseDataComponent Component { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}