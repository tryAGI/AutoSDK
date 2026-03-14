//HintName: G.Models.CreateInputRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateInputRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        Interrupt,
        /// <summary>
        /// 
        /// </summary>
        Compact,
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
                CreateInputRequestDiscriminatorType.InputMessage => "input_message",
                CreateInputRequestDiscriminatorType.Interrupt => "interrupt",
                CreateInputRequestDiscriminatorType.Compact => "compact",
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
                "input_message" => CreateInputRequestDiscriminatorType.InputMessage,
                "interrupt" => CreateInputRequestDiscriminatorType.Interrupt,
                "compact" => CreateInputRequestDiscriminatorType.Compact,
                _ => null,
            };
        }
    }
}