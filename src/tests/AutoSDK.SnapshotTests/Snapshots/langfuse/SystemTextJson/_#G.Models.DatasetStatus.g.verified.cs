//HintName: G.Models.DatasetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetStatus value)
        {
            return value switch
            {
                DatasetStatus.Active => "ACTIVE",
                DatasetStatus.Archived => "ARCHIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => DatasetStatus.Active,
                "ARCHIVED" => DatasetStatus.Archived,
                _ => null,
            };
        }
    }
}