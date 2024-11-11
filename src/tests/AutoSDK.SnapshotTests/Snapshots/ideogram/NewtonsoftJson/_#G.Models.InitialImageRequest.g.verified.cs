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
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("image_weight")]
        public int? ImageWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitialImageRequest" /> class.
        /// </summary>
        /// <param name="imageWeight">
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        public InitialImageRequest(
            int? imageWeight)
        {
            this.ImageWeight = imageWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitialImageRequest" /> class.
        /// </summary>
        public InitialImageRequest()
        {
        }
    }
}