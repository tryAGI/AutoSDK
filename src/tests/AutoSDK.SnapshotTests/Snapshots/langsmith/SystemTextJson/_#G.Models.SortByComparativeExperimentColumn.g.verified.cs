//HintName: G.Models.SortByComparativeExperimentColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for available comparative experiment columns to sort by.
    /// </summary>
    public enum SortByComparativeExperimentColumn
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortByComparativeExperimentColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SortByComparativeExperimentColumn value)
        {
            return value switch
            {
                SortByComparativeExperimentColumn.CreatedAt => "created_at",
                SortByComparativeExperimentColumn.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SortByComparativeExperimentColumn? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => SortByComparativeExperimentColumn.CreatedAt,
                "name" => SortByComparativeExperimentColumn.Name,
                _ => null,
            };
        }
    }
}