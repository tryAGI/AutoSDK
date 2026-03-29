//HintName: G.Models.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType value)
        {
            return value switch
            {
                MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio => "audio",
                MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code => "code",
                MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image => "image",
                MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown => "markdown",
                MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf => "pdf",
                MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text => "text",
                MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio,
                "code" => MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code,
                "image" => MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image,
                "markdown" => MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown,
                "pdf" => MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf,
                "text" => MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text,
                "video" => MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video,
                _ => null,
            };
        }
    }
}