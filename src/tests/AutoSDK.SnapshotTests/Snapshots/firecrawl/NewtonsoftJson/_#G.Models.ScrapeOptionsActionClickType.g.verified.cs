//HintName: G.Models.ScrapeOptionsActionClickType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Click on an element
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScrapeOptionsActionClickType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="click")]
        Click,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsActionClickTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsActionClickType value)
        {
            return value switch
            {
                ScrapeOptionsActionClickType.Click => "click",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsActionClickType? ToEnum(string value)
        {
            return value switch
            {
                "click" => ScrapeOptionsActionClickType.Click,
                _ => null,
            };
        }
    }
}