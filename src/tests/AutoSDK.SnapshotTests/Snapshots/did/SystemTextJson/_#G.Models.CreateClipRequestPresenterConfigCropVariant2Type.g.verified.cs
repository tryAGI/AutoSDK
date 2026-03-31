//HintName: G.Models.CreateClipRequestPresenterConfigCropVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    public enum CreateClipRequestPresenterConfigCropVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Rectangle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipRequestPresenterConfigCropVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestPresenterConfigCropVariant2Type value)
        {
            return value switch
            {
                CreateClipRequestPresenterConfigCropVariant2Type.Rectangle => "rectangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestPresenterConfigCropVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "rectangle" => CreateClipRequestPresenterConfigCropVariant2Type.Rectangle,
                _ => null,
            };
        }
    }
}