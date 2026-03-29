//HintName: G.Models.StabilityAiGeneratedAssetOptionsDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StabilityAiGeneratedAssetOptionsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-image")]
        TextToImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StabilityAiGeneratedAssetOptionsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StabilityAiGeneratedAssetOptionsDiscriminatorType value)
        {
            return value switch
            {
                StabilityAiGeneratedAssetOptionsDiscriminatorType.TextToImage => "text-to-image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StabilityAiGeneratedAssetOptionsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-image" => StabilityAiGeneratedAssetOptionsDiscriminatorType.TextToImage,
                _ => null,
            };
        }
    }
}