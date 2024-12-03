//HintName: G.Models.ImageGenerationRequestCharacterRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationRequestCharacterRef
    {
        /// <summary>
        /// The image identity object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identity0")]
        public global::G.ImageIdentity? Identity0 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequestCharacterRef" /> class.
        /// </summary>
        /// <param name="identity0">
        /// The image identity object
        /// </param>
        public ImageGenerationRequestCharacterRef(
            global::G.ImageIdentity? identity0)
        {
            this.Identity0 = identity0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequestCharacterRef" /> class.
        /// </summary>
        public ImageGenerationRequestCharacterRef()
        {
        }
    }
}