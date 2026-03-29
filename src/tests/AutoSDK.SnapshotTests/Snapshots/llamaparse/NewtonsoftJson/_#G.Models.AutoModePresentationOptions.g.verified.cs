//HintName: G.Models.AutoModePresentationOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presentation-specific options for auto mode parsing configuration.
    /// </summary>
    public sealed partial class AutoModePresentationOptions
    {
        /// <summary>
        /// Extract out of bounds content in presentation slides
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("out_of_bounds_content")]
        public bool? OutOfBoundsContent { get; set; }

        /// <summary>
        /// Skip extraction of embedded data for charts in presentation slides
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skip_embedded_data")]
        public bool? SkipEmbeddedData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModePresentationOptions" /> class.
        /// </summary>
        /// <param name="outOfBoundsContent">
        /// Extract out of bounds content in presentation slides
        /// </param>
        /// <param name="skipEmbeddedData">
        /// Skip extraction of embedded data for charts in presentation slides
        /// </param>
        public AutoModePresentationOptions(
            bool? outOfBoundsContent,
            bool? skipEmbeddedData)
        {
            this.OutOfBoundsContent = outOfBoundsContent;
            this.SkipEmbeddedData = skipEmbeddedData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModePresentationOptions" /> class.
        /// </summary>
        public AutoModePresentationOptions()
        {
        }
    }
}