//HintName: G.Models.CreateClipStreamRequestPresenterConfigCropVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipStreamRequestPresenterConfigCropVariant1Type
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
    public static class CreateClipStreamRequestPresenterConfigCropVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestPresenterConfigCropVariant1Type value)
        {
            return value switch
            {
                CreateClipStreamRequestPresenterConfigCropVariant1Type.Wide => "wide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestPresenterConfigCropVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "wide" => CreateClipStreamRequestPresenterConfigCropVariant1Type.Wide,
                _ => null,
            };
        }
    }
}