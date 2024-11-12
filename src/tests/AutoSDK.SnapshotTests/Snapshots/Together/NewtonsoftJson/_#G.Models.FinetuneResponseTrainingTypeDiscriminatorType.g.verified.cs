//HintName: G.Models.FinetuneResponseTrainingTypeDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinetuneResponseTrainingTypeDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Full")]
        Full,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Lora")]
        Lora,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneResponseTrainingTypeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneResponseTrainingTypeDiscriminatorType value)
        {
            return value switch
            {
                FinetuneResponseTrainingTypeDiscriminatorType.Full => "Full",
                FinetuneResponseTrainingTypeDiscriminatorType.Lora => "Lora",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneResponseTrainingTypeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "Full" => FinetuneResponseTrainingTypeDiscriminatorType.Full,
                "Lora" => FinetuneResponseTrainingTypeDiscriminatorType.Lora,
                _ => null,
            };
        }
    }
}