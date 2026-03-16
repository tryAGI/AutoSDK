//HintName: G.Models.RequestGemini25FlashRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output image.
    /// </summary>
    public enum RequestGemini25FlashRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1344_768,
        /// <summary>
        /// 
        /// </summary>
        x768_1344,
        /// <summary>
        /// 
        /// </summary>
        x1024_1024,
        /// <summary>
        /// 
        /// </summary>
        x1184_864,
        /// <summary>
        /// 
        /// </summary>
        x864_1184,
        /// <summary>
        /// 
        /// </summary>
        x1536_672,
        /// <summary>
        /// 
        /// </summary>
        x832_1248,
        /// <summary>
        /// 
        /// </summary>
        x1248_832,
        /// <summary>
        /// 
        /// </summary>
        x896_1152,
        /// <summary>
        /// 
        /// </summary>
        x1152_896,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestGemini25FlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGemini25FlashRatio value)
        {
            return value switch
            {
                RequestGemini25FlashRatio.x1344_768 => "1344:768",
                RequestGemini25FlashRatio.x768_1344 => "768:1344",
                RequestGemini25FlashRatio.x1024_1024 => "1024:1024",
                RequestGemini25FlashRatio.x1184_864 => "1184:864",
                RequestGemini25FlashRatio.x864_1184 => "864:1184",
                RequestGemini25FlashRatio.x1536_672 => "1536:672",
                RequestGemini25FlashRatio.x832_1248 => "832:1248",
                RequestGemini25FlashRatio.x1248_832 => "1248:832",
                RequestGemini25FlashRatio.x896_1152 => "896:1152",
                RequestGemini25FlashRatio.x1152_896 => "1152:896",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGemini25FlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "1344:768" => RequestGemini25FlashRatio.x1344_768,
                "768:1344" => RequestGemini25FlashRatio.x768_1344,
                "1024:1024" => RequestGemini25FlashRatio.x1024_1024,
                "1184:864" => RequestGemini25FlashRatio.x1184_864,
                "864:1184" => RequestGemini25FlashRatio.x864_1184,
                "1536:672" => RequestGemini25FlashRatio.x1536_672,
                "832:1248" => RequestGemini25FlashRatio.x832_1248,
                "1248:832" => RequestGemini25FlashRatio.x1248_832,
                "896:1152" => RequestGemini25FlashRatio.x896_1152,
                "1152:896" => RequestGemini25FlashRatio.x1152_896,
                _ => null,
            };
        }
    }
}