//HintName: G.Models.GetUserActiveExtensionsResponseDataOverlay.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary that contains the data for a video-overlay extension. The dictionary’s key is a sequential number beginning with 1\. The following fields contain the overlay’s data for each key.
    /// </summary>
    public sealed partial class GetUserActiveExtensionsResponseDataOverlay
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserActiveExtensionsResponseDataOverlay" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetUserActiveExtensionsResponseDataOverlay(
 )
        {
        }
    }
}