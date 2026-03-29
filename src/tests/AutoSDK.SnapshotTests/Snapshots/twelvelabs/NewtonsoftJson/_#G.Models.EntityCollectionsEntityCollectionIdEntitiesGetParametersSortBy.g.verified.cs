//HintName: G.Models.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated_at")]
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy value)
        {
            return value switch
            {
                EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy.CreatedAt => "created_at",
                EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy.Name => "name",
                EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy.CreatedAt,
                "name" => EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy.Name,
                "updated_at" => EntityCollectionsEntityCollectionIdEntitiesGetParametersSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}