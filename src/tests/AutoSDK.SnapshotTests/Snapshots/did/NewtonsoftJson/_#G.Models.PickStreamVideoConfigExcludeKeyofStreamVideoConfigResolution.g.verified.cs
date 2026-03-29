//HintName: G.Models.PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolution
    {
        /// <summary>
        /// The background of the streamed video.<br/>
        /// default to solid white background<br/>
        /// example: { color: '#ffffff' }
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolutionBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolution" /> class.
        /// </summary>
        /// <param name="background">
        /// The background of the streamed video.<br/>
        /// default to solid white background<br/>
        /// example: { color: '#ffffff' }
        /// </param>
        public PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolution(
            global::G.PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolutionBackground? background)
        {
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolution" /> class.
        /// </summary>
        public PickStreamVideoConfigExcludeKeyofStreamVideoConfigResolution()
        {
        }
    }
}