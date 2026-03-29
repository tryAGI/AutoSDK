//HintName: G.Models.ImageRefMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ImageRefMode.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageRefMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedded")]
        Embedded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="placeholder")]
        Placeholder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="referenced")]
        Referenced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageRefModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRefMode value)
        {
            return value switch
            {
                ImageRefMode.Embedded => "embedded",
                ImageRefMode.Placeholder => "placeholder",
                ImageRefMode.Referenced => "referenced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRefMode? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => ImageRefMode.Embedded,
                "placeholder" => ImageRefMode.Placeholder,
                "referenced" => ImageRefMode.Referenced,
                _ => null,
            };
        }
    }
}