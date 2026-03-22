//HintName: G.Models.SortByDatasetColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for available dataset columns to sort by.
    /// </summary>
    public enum SortByDatasetColumn
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        ExampleCount,
        /// <summary>
        /// 
        /// </summary>
        LastSessionStartTime,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        SessionCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortByDatasetColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SortByDatasetColumn value)
        {
            return value switch
            {
                SortByDatasetColumn.CreatedAt => "created_at",
                SortByDatasetColumn.ExampleCount => "example_count",
                SortByDatasetColumn.LastSessionStartTime => "last_session_start_time",
                SortByDatasetColumn.Name => "name",
                SortByDatasetColumn.SessionCount => "session_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SortByDatasetColumn? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => SortByDatasetColumn.CreatedAt,
                "example_count" => SortByDatasetColumn.ExampleCount,
                "last_session_start_time" => SortByDatasetColumn.LastSessionStartTime,
                "name" => SortByDatasetColumn.Name,
                "session_count" => SortByDatasetColumn.SessionCount,
                _ => null,
            };
        }
    }
}