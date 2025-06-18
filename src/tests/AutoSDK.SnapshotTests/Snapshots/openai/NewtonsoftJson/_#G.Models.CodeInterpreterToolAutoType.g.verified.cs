//HintName: G.Models.CodeInterpreterToolAutoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `auto`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeInterpreterToolAutoType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterToolAutoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterToolAutoType value)
        {
            return value switch
            {
                CodeInterpreterToolAutoType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterToolAutoType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CodeInterpreterToolAutoType.Auto,
                _ => null,
            };
        }
    }
}