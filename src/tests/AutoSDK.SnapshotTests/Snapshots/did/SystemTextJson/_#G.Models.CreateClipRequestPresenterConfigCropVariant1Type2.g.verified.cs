//HintName: G.Models.CreateClipRequestPresenterConfigCropVariant1Type2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    public enum CreateClipRequestPresenterConfigCropVariant1Type2
    {
        /// <summary>
        /// 
        /// </summary>
        Wide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipRequestPresenterConfigCropVariant1Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestPresenterConfigCropVariant1Type2 value)
        {
            return value switch
            {
                CreateClipRequestPresenterConfigCropVariant1Type2.Wide => "wide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestPresenterConfigCropVariant1Type2? ToEnum(string value)
        {
            return value switch
            {
                "wide" => CreateClipRequestPresenterConfigCropVariant1Type2.Wide,
                _ => null,
            };
        }
    }
}