//HintName: G.Models.InitialImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A request to generate a new image using a provided image and a prompt.
    /// </summary>
    public sealed partial class InitialImageRequest
    {
        /// <summary>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_weight")]
        public int? ImageWeight { get; set; } = 50;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}