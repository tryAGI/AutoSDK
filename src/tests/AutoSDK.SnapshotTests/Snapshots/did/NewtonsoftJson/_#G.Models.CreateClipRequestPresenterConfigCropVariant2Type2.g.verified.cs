//HintName: G.Models.CreateClipRequestPresenterConfigCropVariant2Type2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipRequestPresenterConfigCropVariant2Type2
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
    public static class CreateClipRequestPresenterConfigCropVariant2Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestPresenterConfigCropVariant2Type2 value)
        {
            return value switch
            {
                CreateClipRequestPresenterConfigCropVariant2Type2.Rectangle => "rectangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestPresenterConfigCropVariant2Type2? ToEnum(string value)
        {
            return value switch
            {
                "rectangle" => CreateClipRequestPresenterConfigCropVariant2Type2.Rectangle,
                _ => null,
            };
        }
    }
}