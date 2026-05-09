//HintName: G.Models.CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorType value)
        {
            return value switch
            {
                CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorType.Image,
                _ => null,
            };
        }
    }
}