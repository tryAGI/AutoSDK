//HintName: G.Models.InputBackgroundSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputBackgroundSettings
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public global::G.InputBackgroundPosition? Position { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale")]
        public double? Scale { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("videoSettings")]
        public global::G.InputVideoBackgroundSettings? VideoSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputBackgroundSettings" /> class.
        /// </summary>
        /// <param name="position">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scale">
        /// Default Value: 1F
        /// </param>
        /// <param name="videoSettings">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public InputBackgroundSettings(
            global::G.InputBackgroundPosition? position,
            double? scale,
            global::G.InputVideoBackgroundSettings? videoSettings)
        {
            this.Position = position;
            this.Scale = scale;
            this.VideoSettings = videoSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputBackgroundSettings" /> class.
        /// </summary>
        public InputBackgroundSettings()
        {
        }
    }
}