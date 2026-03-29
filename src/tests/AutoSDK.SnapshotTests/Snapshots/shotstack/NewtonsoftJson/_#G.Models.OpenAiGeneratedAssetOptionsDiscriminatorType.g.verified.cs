//HintName: G.Models.OpenAiGeneratedAssetOptionsDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAiGeneratedAssetOptionsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-generator")]
        TextGenerator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiGeneratedAssetOptionsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiGeneratedAssetOptionsDiscriminatorType value)
        {
            return value switch
            {
                OpenAiGeneratedAssetOptionsDiscriminatorType.TextGenerator => "text-generator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiGeneratedAssetOptionsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text-generator" => OpenAiGeneratedAssetOptionsDiscriminatorType.TextGenerator,
                _ => null,
            };
        }
    }
}