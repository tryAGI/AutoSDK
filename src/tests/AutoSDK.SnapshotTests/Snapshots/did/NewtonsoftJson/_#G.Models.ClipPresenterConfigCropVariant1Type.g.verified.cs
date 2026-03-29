//HintName: G.Models.ClipPresenterConfigCropVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipPresenterConfigCropVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wide")]
        Wide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipPresenterConfigCropVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipPresenterConfigCropVariant1Type value)
        {
            return value switch
            {
                ClipPresenterConfigCropVariant1Type.Wide => "wide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipPresenterConfigCropVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "wide" => ClipPresenterConfigCropVariant1Type.Wide,
                _ => null,
            };
        }
    }
}