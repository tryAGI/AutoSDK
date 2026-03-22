//HintName: G.Models.CreateInputRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateInputRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="compact")]
        Compact,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_message")]
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="interrupt")]
        Interrupt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateInputRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateInputRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateInputRequestDiscriminatorType.Compact => "compact",
                CreateInputRequestDiscriminatorType.InputMessage => "input_message",
                CreateInputRequestDiscriminatorType.Interrupt => "interrupt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateInputRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "compact" => CreateInputRequestDiscriminatorType.Compact,
                "input_message" => CreateInputRequestDiscriminatorType.InputMessage,
                "interrupt" => CreateInputRequestDiscriminatorType.Interrupt,
                _ => null,
            };
        }
    }
}