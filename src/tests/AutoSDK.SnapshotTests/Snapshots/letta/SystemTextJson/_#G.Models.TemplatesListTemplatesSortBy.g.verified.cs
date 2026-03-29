//HintName: G.Models.TemplatesListTemplatesSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesListTemplatesSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesListTemplatesSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesListTemplatesSortBy value)
        {
            return value switch
            {
                TemplatesListTemplatesSortBy.CreatedAt => "created_at",
                TemplatesListTemplatesSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesListTemplatesSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => TemplatesListTemplatesSortBy.CreatedAt,
                "updated_at" => TemplatesListTemplatesSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}