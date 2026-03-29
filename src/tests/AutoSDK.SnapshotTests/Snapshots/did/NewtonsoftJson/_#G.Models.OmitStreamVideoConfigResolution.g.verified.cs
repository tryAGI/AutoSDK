//HintName: G.Models.OmitStreamVideoConfigResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Construct a type with the properties of T except for those in type K.
    /// </summary>
    public sealed partial class OmitStreamVideoConfigResolution
    {
        /// <summary>
        /// The background of the streamed video.<br/>
        /// default to solid white background<br/>
        /// example: { color: '#ffffff' }
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.OmitStreamVideoConfigResolutionBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitStreamVideoConfigResolution" /> class.
        /// </summary>
        /// <param name="background">
        /// The background of the streamed video.<br/>
        /// default to solid white background<br/>
        /// example: { color: '#ffffff' }
        /// </param>
        public OmitStreamVideoConfigResolution(
            global::G.OmitStreamVideoConfigResolutionBackground? background)
        {
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitStreamVideoConfigResolution" /> class.
        /// </summary>
        public OmitStreamVideoConfigResolution()
        {
        }
    }
}