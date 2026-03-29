//HintName: G.Models.WebSearchToolUserLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchToolUserLocation
    {
        /// <summary>
        /// The type of location approximation. Always `approximate`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WebSearchToolUserLocationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolUserLocation" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of location approximation. Always `approximate`.
        /// </param>
        public WebSearchToolUserLocation(
            global::G.WebSearchToolUserLocationType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolUserLocation" /> class.
        /// </summary>
        public WebSearchToolUserLocation()
        {
        }
    }
}