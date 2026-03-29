//HintName: G.Models.ScrapeOptionsActionScrollType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Scroll the page or a specific element
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScrapeOptionsActionScrollType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scroll")]
        Scroll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsActionScrollTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsActionScrollType value)
        {
            return value switch
            {
                ScrapeOptionsActionScrollType.Scroll => "scroll",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsActionScrollType? ToEnum(string value)
        {
            return value switch
            {
                "scroll" => ScrapeOptionsActionScrollType.Scroll,
                _ => null,
            };
        }
    }
}