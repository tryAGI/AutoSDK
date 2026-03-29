//HintName: G.Models.CreateClipRequestPresenterConfigCropVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipRequestPresenterConfigCropVariant1Type
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
    public static class CreateClipRequestPresenterConfigCropVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestPresenterConfigCropVariant1Type value)
        {
            return value switch
            {
                CreateClipRequestPresenterConfigCropVariant1Type.Wide => "wide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestPresenterConfigCropVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "wide" => CreateClipRequestPresenterConfigCropVariant1Type.Wide,
                _ => null,
            };
        }
    }
}