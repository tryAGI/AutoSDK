//HintName: G.Models.CreateImageGenerationRequestImageReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of image reference.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageGenerationRequestImageReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="face")]
        Face,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subject")]
        Subject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageGenerationRequestImageReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageGenerationRequestImageReference value)
        {
            return value switch
            {
                CreateImageGenerationRequestImageReference.Face => "face",
                CreateImageGenerationRequestImageReference.Subject => "subject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageGenerationRequestImageReference? ToEnum(string value)
        {
            return value switch
            {
                "face" => CreateImageGenerationRequestImageReference.Face,
                "subject" => CreateImageGenerationRequestImageReference.Subject,
                _ => null,
            };
        }
    }
}