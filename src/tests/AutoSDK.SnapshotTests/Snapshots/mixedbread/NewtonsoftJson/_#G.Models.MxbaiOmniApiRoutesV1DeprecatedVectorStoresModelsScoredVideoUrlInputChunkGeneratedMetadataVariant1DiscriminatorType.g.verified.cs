//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code")]
        Code,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pdf")]
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType value)
        {
            return value switch
            {
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio => "audio",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code => "code",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image => "image",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown => "markdown",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf => "pdf",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text => "text",
                MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio,
                "code" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code,
                "image" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image,
                "markdown" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown,
                "pdf" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf,
                "text" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text,
                "video" => MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video,
                _ => null,
            };
        }
    }
}