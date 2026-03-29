//HintName: G.Models.ToolCallContentPartToolCallDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolCallContentPartToolCallDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallContentPartToolCallDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallContentPartToolCallDiscriminatorType value)
        {
            return value switch
            {
                ToolCallContentPartToolCallDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallContentPartToolCallDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolCallContentPartToolCallDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}