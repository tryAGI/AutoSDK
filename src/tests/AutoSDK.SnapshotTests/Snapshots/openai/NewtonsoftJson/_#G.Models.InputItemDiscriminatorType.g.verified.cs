//HintName: G.Models.InputItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message")]
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputItemDiscriminatorType value)
        {
            return value switch
            {
                InputItemDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "message" => InputItemDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}