//HintName: G.Models.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus value)
        {
            return value switch
            {
                EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus.Processing => "processing",
                EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus.Processing,
                "ready" => EntityCollectionsEntityCollectionIdEntitiesGetParametersStatus.Ready,
                _ => null,
            };
        }
    }
}