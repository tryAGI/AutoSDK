//HintName: G.Models.DatasetFilterNodeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetFilterNodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetFilterNodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetFilterNodeEnum value)
        {
            return value switch
            {
                DatasetFilterNodeEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetFilterNodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => DatasetFilterNodeEnum.All,
                _ => null,
            };
        }
    }
}