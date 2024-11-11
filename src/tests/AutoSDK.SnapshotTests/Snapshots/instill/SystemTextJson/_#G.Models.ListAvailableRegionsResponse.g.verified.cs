//HintName: G.Models.ListAvailableRegionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListAvailableRegionsResponse contains a list of available<br/>
    /// regions and hardware types a model can be deployed on.
    /// </summary>
    public sealed partial class ListAvailableRegionsResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<global::G.Region>? Regions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAvailableRegionsResponse" /> class.
        /// </summary>
        /// <param name="regions">
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListAvailableRegionsResponse(
            global::System.Collections.Generic.IList<global::G.Region>? regions)
        {
            this.Regions = regions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAvailableRegionsResponse" /> class.
        /// </summary>
        public ListAvailableRegionsResponse()
        {
        }
    }
}