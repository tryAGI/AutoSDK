//HintName: G.Models.OutputDatetimeItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputDatetimeItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_datetime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputDatetimeItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputDatetimeItemType value)
        {
            return value switch
            {
                OutputDatetimeItemType.Openrouter_datetime => "openrouter:datetime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputDatetimeItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:datetime" => OutputDatetimeItemType.Openrouter_datetime,
                _ => null,
            };
        }
    }
}