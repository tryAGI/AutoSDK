//HintName: G.Models.CreateClipStreamRequestPresenterConfigCropVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipStreamRequestPresenterConfigCropVariant2Type
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
    public static class CreateClipStreamRequestPresenterConfigCropVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestPresenterConfigCropVariant2Type value)
        {
            return value switch
            {
                CreateClipStreamRequestPresenterConfigCropVariant2Type.Rectangle => "rectangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestPresenterConfigCropVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "rectangle" => CreateClipStreamRequestPresenterConfigCropVariant2Type.Rectangle,
                _ => null,
            };
        }
    }
}