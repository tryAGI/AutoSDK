//HintName: G.Models.TextScript3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextScript3Type
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
    public static class TextScript3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScript3Type value)
        {
            return value switch
            {
                TextScript3Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScript3Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextScript3Type.Text,
                _ => null,
            };
        }
    }
}