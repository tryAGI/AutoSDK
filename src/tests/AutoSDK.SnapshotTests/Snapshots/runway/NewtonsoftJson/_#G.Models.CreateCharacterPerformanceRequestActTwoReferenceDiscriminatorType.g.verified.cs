//HintName: G.Models.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType value)
        {
            return value switch
            {
                CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "video" => CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType.Video,
                _ => null,
            };
        }
    }
}