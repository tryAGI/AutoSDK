//HintName: G.Models.AudioEnhancementDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioEnhancementDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhancement")]
        public string? Enhancement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEnhancementDiscriminator" /> class.
        /// </summary>
        /// <param name="enhancement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEnhancementDiscriminator(
            string? enhancement)
        {
            this.Enhancement = enhancement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEnhancementDiscriminator" /> class.
        /// </summary>
        public AudioEnhancementDiscriminator()
        {
        }
    }
}