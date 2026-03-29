//HintName: G.Models.PresentFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PresentFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        Present,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PresentFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresentFilterType value)
        {
            return value switch
            {
                PresentFilterType.Present => "present",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresentFilterType? ToEnum(string value)
        {
            return value switch
            {
                "present" => PresentFilterType.Present,
                _ => null,
            };
        }
    }
}