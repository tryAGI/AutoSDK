//HintName: G.Models.OcrEnginesEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OcrEnginesEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easyocr")]
        Easyocr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ocrmac")]
        Ocrmac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rapidocr")]
        Rapidocr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tesseract")]
        Tesseract,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tesserocr")]
        Tesserocr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OcrEnginesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OcrEnginesEnum value)
        {
            return value switch
            {
                OcrEnginesEnum.Auto => "auto",
                OcrEnginesEnum.Easyocr => "easyocr",
                OcrEnginesEnum.Ocrmac => "ocrmac",
                OcrEnginesEnum.Rapidocr => "rapidocr",
                OcrEnginesEnum.Tesseract => "tesseract",
                OcrEnginesEnum.Tesserocr => "tesserocr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OcrEnginesEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => OcrEnginesEnum.Auto,
                "easyocr" => OcrEnginesEnum.Easyocr,
                "ocrmac" => OcrEnginesEnum.Ocrmac,
                "rapidocr" => OcrEnginesEnum.Rapidocr,
                "tesseract" => OcrEnginesEnum.Tesseract,
                "tesserocr" => OcrEnginesEnum.Tesserocr,
                _ => null,
            };
        }
    }
}