//HintName: G.Models.SortByComparativeExperimentColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for available comparative experiment columns to sort by.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SortByComparativeExperimentColumn
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
                SortByComparativeExperimentColumn.Name => "name",
                SortByComparativeExperimentColumn.CreatedAt => "created_at",
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
                "name" => SortByComparativeExperimentColumn.Name,
                "created_at" => SortByComparativeExperimentColumn.CreatedAt,
                _ => null,
            };
        }
    }
}