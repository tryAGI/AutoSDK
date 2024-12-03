//HintName: G.Models.KeyframeDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KeyframeDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation")]
        Generation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyframeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyframeDiscriminatorType value)
        {
            return value switch
            {
                KeyframeDiscriminatorType.Generation => "generation",
                KeyframeDiscriminatorType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyframeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "generation" => KeyframeDiscriminatorType.Generation,
                "image" => KeyframeDiscriminatorType.Image,
                _ => null,
            };
        }
    }
}