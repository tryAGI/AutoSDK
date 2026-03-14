//HintName: G.Models.UpdateInstructionRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateInstructionRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Initial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInstructionRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInstructionRequestDiscriminatorType value)
        {
            return value switch
            {
                UpdateInstructionRequestDiscriminatorType.Initial => "initial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInstructionRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "initial" => UpdateInstructionRequestDiscriminatorType.Initial,
                _ => null,
            };
        }
    }
}