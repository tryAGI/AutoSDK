//HintName: G.Models.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType
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
    public static class MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType value)
        {
            return value switch
            {
                MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio => "audio",
                MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code => "code",
                MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image => "image",
                MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown => "markdown",
                MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf => "pdf",
                MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text => "text",
                MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio,
                "code" => MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code,
                "image" => MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image,
                "markdown" => MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown,
                "pdf" => MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf,
                "text" => MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text,
                "video" => MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video,
                _ => null,
            };
        }
    }
}