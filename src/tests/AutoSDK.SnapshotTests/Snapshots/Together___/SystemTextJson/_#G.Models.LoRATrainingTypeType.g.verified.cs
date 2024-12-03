//HintName: G.Models.LoRATrainingTypeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LoRATrainingTypeType
    {
        /// <summary>
        /// 
        /// </summary>
        Lora,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LoRATrainingTypeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoRATrainingTypeType value)
        {
            return value switch
            {
                LoRATrainingTypeType.Lora => "Lora",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoRATrainingTypeType? ToEnum(string value)
        {
            return value switch
            {
                "Lora" => LoRATrainingTypeType.Lora,
                _ => null,
            };
        }
    }
}