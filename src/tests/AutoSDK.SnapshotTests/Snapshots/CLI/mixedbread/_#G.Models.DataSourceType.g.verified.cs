//HintName: G.Models.DataSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Linear,
        /// <summary>
        /// 
        /// </summary>
        Notion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataSourceType value)
        {
            return value switch
            {
                DataSourceType.Linear => "linear",
                DataSourceType.Notion => "notion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataSourceType? ToEnum(string value)
        {
            return value switch
            {
                "linear" => DataSourceType.Linear,
                "notion" => DataSourceType.Notion,
                _ => null,
            };
        }
    }
}