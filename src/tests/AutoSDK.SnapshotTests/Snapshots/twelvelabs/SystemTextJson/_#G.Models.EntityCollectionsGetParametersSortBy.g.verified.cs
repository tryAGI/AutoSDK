//HintName: G.Models.EntityCollectionsGetParametersSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created_at
    /// </summary>
    public enum EntityCollectionsGetParametersSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityCollectionsGetParametersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityCollectionsGetParametersSortBy value)
        {
            return value switch
            {
                EntityCollectionsGetParametersSortBy.CreatedAt => "created_at",
                EntityCollectionsGetParametersSortBy.Name => "name",
                EntityCollectionsGetParametersSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityCollectionsGetParametersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => EntityCollectionsGetParametersSortBy.CreatedAt,
                "name" => EntityCollectionsGetParametersSortBy.Name,
                "updated_at" => EntityCollectionsGetParametersSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}