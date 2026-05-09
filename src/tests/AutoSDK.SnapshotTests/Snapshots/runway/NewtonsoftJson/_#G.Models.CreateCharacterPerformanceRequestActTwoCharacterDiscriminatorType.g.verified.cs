//HintName: G.Models.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType value)
        {
            return value switch
            {
                CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType.Image => "image",
                CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType.Image,
                "video" => CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType.Video,
                _ => null,
            };
        }
    }
}