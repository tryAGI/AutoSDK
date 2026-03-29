//HintName: G.Models.FileSearchServerToolFiltersOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileSearchServerToolFiltersOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Ne,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSearchServerToolFiltersOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchServerToolFiltersOneOf0Type value)
        {
            return value switch
            {
                FileSearchServerToolFiltersOneOf0Type.Eq => "eq",
                FileSearchServerToolFiltersOneOf0Type.Gt => "gt",
                FileSearchServerToolFiltersOneOf0Type.Gte => "gte",
                FileSearchServerToolFiltersOneOf0Type.Lt => "lt",
                FileSearchServerToolFiltersOneOf0Type.Lte => "lte",
                FileSearchServerToolFiltersOneOf0Type.Ne => "ne",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchServerToolFiltersOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "eq" => FileSearchServerToolFiltersOneOf0Type.Eq,
                "gt" => FileSearchServerToolFiltersOneOf0Type.Gt,
                "gte" => FileSearchServerToolFiltersOneOf0Type.Gte,
                "lt" => FileSearchServerToolFiltersOneOf0Type.Lt,
                "lte" => FileSearchServerToolFiltersOneOf0Type.Lte,
                "ne" => FileSearchServerToolFiltersOneOf0Type.Ne,
                _ => null,
            };
        }
    }
}