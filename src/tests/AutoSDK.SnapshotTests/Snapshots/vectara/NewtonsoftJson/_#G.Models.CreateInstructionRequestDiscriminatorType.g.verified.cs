//HintName: G.Models.CreateInstructionRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateInstructionRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="initial")]
        Initial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateInstructionRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateInstructionRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateInstructionRequestDiscriminatorType.Initial => "initial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateInstructionRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "initial" => CreateInstructionRequestDiscriminatorType.Initial,
                _ => null,
            };
        }
    }
}