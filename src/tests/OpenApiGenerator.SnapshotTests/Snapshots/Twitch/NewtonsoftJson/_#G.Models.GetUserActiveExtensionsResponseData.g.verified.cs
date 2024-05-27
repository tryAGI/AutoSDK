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
        [global::Newtonsoft.Json.JsonProperty("panel")]
        public object? Panel { get; set; }

        /// <summary>
        /// A dictionary that contains the data for a video-overlay extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the overlay’s data for each key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overlay")]
        public object? Overlay { get; set; }

        /// <summary>
        /// A dictionary that contains the data for a video-component extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the component’s data for each key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component")]
        public object? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}