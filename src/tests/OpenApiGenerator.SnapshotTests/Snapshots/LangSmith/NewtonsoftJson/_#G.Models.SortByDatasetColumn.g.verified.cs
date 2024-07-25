//HintName: G.Models.SortByDatasetColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for available dataset columns to sort by.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SortByDatasetColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last_session_start_time")]
        LastSessionStartTime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="example_count")]
        ExampleCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session_count")]
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
                SortByDatasetColumn.Name => "name",
                SortByDatasetColumn.CreatedAt => "created_at",
                SortByDatasetColumn.LastSessionStartTime => "last_session_start_time",
                SortByDatasetColumn.ExampleCount => "example_count",
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
                "name" => SortByDatasetColumn.Name,
                "created_at" => SortByDatasetColumn.CreatedAt,
                "last_session_start_time" => SortByDatasetColumn.LastSessionStartTime,
                "example_count" => SortByDatasetColumn.ExampleCount,
                "session_count" => SortByDatasetColumn.SessionCount,
                _ => null,
            };
        }
    }
}