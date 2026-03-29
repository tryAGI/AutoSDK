//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType
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
    public static class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType value)
        {
            return value switch
            {
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio => "audio",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code => "code",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image => "image",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown => "markdown",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf => "pdf",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text => "text",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio,
                "code" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code,
                "image" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image,
                "markdown" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown,
                "pdf" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf,
                "text" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text,
                "video" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video,
                _ => null,
            };
        }
    }
}