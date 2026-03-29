//HintName: G.Models.CreateClipStreamRequestPresenterConfigCropVariant2Type2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipStreamRequestPresenterConfigCropVariant2Type2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rectangle")]
        Rectangle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipStreamRequestPresenterConfigCropVariant2Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestPresenterConfigCropVariant2Type2 value)
        {
            return value switch
            {
                CreateClipStreamRequestPresenterConfigCropVariant2Type2.Rectangle => "rectangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestPresenterConfigCropVariant2Type2? ToEnum(string value)
        {
            return value switch
            {
                "rectangle" => CreateClipStreamRequestPresenterConfigCropVariant2Type2.Rectangle,
                _ => null,
            };
        }
    }
}