//HintName: G.Models.CreateTextToImageRequestGemini25FlashRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output image.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTextToImageRequestGemini25FlashRatio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024:1024")]
        x1024_1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1152:896")]
        x1152_896,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1184:864")]
        x1184_864,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1248:832")]
        x1248_832,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1344:768")]
        x1344_768,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1536:672")]
        x1536_672,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="768:1344")]
        x768_1344,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="832:1248")]
        x832_1248,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="864:1184")]
        x864_1184,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="896:1152")]
        x896_1152,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGemini25FlashRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGemini25FlashRatio value)
        {
            return value switch
            {
                CreateTextToImageRequestGemini25FlashRatio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestGemini25FlashRatio.x1152_896 => "1152:896",
                CreateTextToImageRequestGemini25FlashRatio.x1184_864 => "1184:864",
                CreateTextToImageRequestGemini25FlashRatio.x1248_832 => "1248:832",
                CreateTextToImageRequestGemini25FlashRatio.x1344_768 => "1344:768",
                CreateTextToImageRequestGemini25FlashRatio.x1536_672 => "1536:672",
                CreateTextToImageRequestGemini25FlashRatio.x768_1344 => "768:1344",
                CreateTextToImageRequestGemini25FlashRatio.x832_1248 => "832:1248",
                CreateTextToImageRequestGemini25FlashRatio.x864_1184 => "864:1184",
                CreateTextToImageRequestGemini25FlashRatio.x896_1152 => "896:1152",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGemini25FlashRatio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestGemini25FlashRatio.x1024_1024,
                "1152:896" => CreateTextToImageRequestGemini25FlashRatio.x1152_896,
                "1184:864" => CreateTextToImageRequestGemini25FlashRatio.x1184_864,
                "1248:832" => CreateTextToImageRequestGemini25FlashRatio.x1248_832,
                "1344:768" => CreateTextToImageRequestGemini25FlashRatio.x1344_768,
                "1536:672" => CreateTextToImageRequestGemini25FlashRatio.x1536_672,
                "768:1344" => CreateTextToImageRequestGemini25FlashRatio.x768_1344,
                "832:1248" => CreateTextToImageRequestGemini25FlashRatio.x832_1248,
                "864:1184" => CreateTextToImageRequestGemini25FlashRatio.x864_1184,
                "896:1152" => CreateTextToImageRequestGemini25FlashRatio.x896_1152,
                _ => null,
            };
        }
    }
}