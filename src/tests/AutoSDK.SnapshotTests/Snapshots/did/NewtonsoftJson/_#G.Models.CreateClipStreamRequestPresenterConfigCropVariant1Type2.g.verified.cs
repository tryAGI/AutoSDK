//HintName: G.Models.CreateClipStreamRequestPresenterConfigCropVariant1Type2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipStreamRequestPresenterConfigCropVariant1Type2
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
    public static class CreateClipStreamRequestPresenterConfigCropVariant1Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestPresenterConfigCropVariant1Type2 value)
        {
            return value switch
            {
                CreateClipStreamRequestPresenterConfigCropVariant1Type2.Wide => "wide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestPresenterConfigCropVariant1Type2? ToEnum(string value)
        {
            return value switch
            {
                "wide" => CreateClipStreamRequestPresenterConfigCropVariant1Type2.Wide,
                _ => null,
            };
        }
    }
}