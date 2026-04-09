//HintName: G.Models.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectExternalAudioResponseModelSourceContextVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter))]
        public global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? SourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExternalAudioResponseModelSourceContextVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="sourceType"></param>
        public ProjectExternalAudioResponseModelSourceContextVariant1Discriminator(
            global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? sourceType)
        {
            this.SourceType = sourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExternalAudioResponseModelSourceContextVariant1Discriminator" /> class.
        /// </summary>
        public ProjectExternalAudioResponseModelSourceContextVariant1Discriminator()
        {
        }
    }
}