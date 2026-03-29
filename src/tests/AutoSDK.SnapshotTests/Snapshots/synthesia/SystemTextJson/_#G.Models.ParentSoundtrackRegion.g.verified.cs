//HintName: G.Models.ParentSoundtrackRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParentSoundtrackRegion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soundtrack")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Soundtrack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slideRange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlideRange { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fadeInSeconds")]
        public double? FadeInSeconds { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fadeOutSeconds")]
        public double? FadeOutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentSoundtrackRegion" /> class.
        /// </summary>
        /// <param name="soundtrack"></param>
        /// <param name="slideRange"></param>
        /// <param name="fadeInSeconds">
        /// Default Value: 0F
        /// </param>
        /// <param name="fadeOutSeconds">
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParentSoundtrackRegion(
            string soundtrack,
            string slideRange,
            double? fadeInSeconds,
            double? fadeOutSeconds)
        {
            this.Soundtrack = soundtrack ?? throw new global::System.ArgumentNullException(nameof(soundtrack));
            this.SlideRange = slideRange ?? throw new global::System.ArgumentNullException(nameof(slideRange));
            this.FadeInSeconds = fadeInSeconds;
            this.FadeOutSeconds = fadeOutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentSoundtrackRegion" /> class.
        /// </summary>
        public ParentSoundtrackRegion()
        {
        }
    }
}