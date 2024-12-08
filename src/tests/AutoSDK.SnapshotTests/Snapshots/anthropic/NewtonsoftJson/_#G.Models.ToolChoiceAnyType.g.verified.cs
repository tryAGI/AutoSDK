//HintName: G.Models.ToolChoiceAnyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolChoiceAnyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="any")]
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceAnyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceAnyType value)
        {
            return value switch
            {
                ToolChoiceAnyType.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceAnyType? ToEnum(string value)
        {
            return value switch
            {
                "any" => ToolChoiceAnyType.Any,
                _ => null,
            };
        }
    }
}