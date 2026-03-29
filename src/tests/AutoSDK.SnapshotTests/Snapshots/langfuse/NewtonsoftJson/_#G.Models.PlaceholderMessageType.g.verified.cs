//HintName: G.Models.PlaceholderMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PlaceholderMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="placeholder")]
        Placeholder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaceholderMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaceholderMessageType value)
        {
            return value switch
            {
                PlaceholderMessageType.Placeholder => "placeholder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaceholderMessageType? ToEnum(string value)
        {
            return value switch
            {
                "placeholder" => PlaceholderMessageType.Placeholder,
                _ => null,
            };
        }
    }
}