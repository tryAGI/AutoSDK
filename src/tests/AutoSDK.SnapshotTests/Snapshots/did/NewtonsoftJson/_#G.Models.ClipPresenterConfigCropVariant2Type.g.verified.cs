//HintName: G.Models.ClipPresenterConfigCropVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipPresenterConfigCropVariant2Type
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
    public static class ClipPresenterConfigCropVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipPresenterConfigCropVariant2Type value)
        {
            return value switch
            {
                ClipPresenterConfigCropVariant2Type.Rectangle => "rectangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipPresenterConfigCropVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "rectangle" => ClipPresenterConfigCropVariant2Type.Rectangle,
                _ => null,
            };
        }
    }
}