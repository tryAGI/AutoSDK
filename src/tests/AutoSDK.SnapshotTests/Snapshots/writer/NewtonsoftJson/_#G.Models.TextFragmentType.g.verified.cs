//HintName: G.Models.TextFragmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content fragment. Must be `text` for text fragments.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextFragmentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextFragmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextFragmentType value)
        {
            return value switch
            {
                TextFragmentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextFragmentType? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextFragmentType.Text,
                _ => null,
            };
        }
    }
}