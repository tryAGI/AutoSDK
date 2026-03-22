//HintName: G.Models.CreateVideoToVideoRequestGen4AlephRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoToVideoRequestGen4AlephRatio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1104:832")]
        x1104_832,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1280:720")]
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1584:672")]
        x1584_672,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="640:480")]
        x640_480,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="720:1280")]
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="832:1104")]
        x832_1104,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="848:480")]
        x848_480,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="960:960")]
        x960_960,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestGen4AlephRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestGen4AlephRatio value)
        {
            return value switch
            {
                CreateVideoToVideoRequestGen4AlephRatio.x1104_832 => "1104:832",
                CreateVideoToVideoRequestGen4AlephRatio.x1280_720 => "1280:720",
                CreateVideoToVideoRequestGen4AlephRatio.x1584_672 => "1584:672",
                CreateVideoToVideoRequestGen4AlephRatio.x640_480 => "640:480",
                CreateVideoToVideoRequestGen4AlephRatio.x720_1280 => "720:1280",
                CreateVideoToVideoRequestGen4AlephRatio.x832_1104 => "832:1104",
                CreateVideoToVideoRequestGen4AlephRatio.x848_480 => "848:480",
                CreateVideoToVideoRequestGen4AlephRatio.x960_960 => "960:960",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestGen4AlephRatio? ToEnum(string value)
        {
            return value switch
            {
                "1104:832" => CreateVideoToVideoRequestGen4AlephRatio.x1104_832,
                "1280:720" => CreateVideoToVideoRequestGen4AlephRatio.x1280_720,
                "1584:672" => CreateVideoToVideoRequestGen4AlephRatio.x1584_672,
                "640:480" => CreateVideoToVideoRequestGen4AlephRatio.x640_480,
                "720:1280" => CreateVideoToVideoRequestGen4AlephRatio.x720_1280,
                "832:1104" => CreateVideoToVideoRequestGen4AlephRatio.x832_1104,
                "848:480" => CreateVideoToVideoRequestGen4AlephRatio.x848_480,
                "960:960" => CreateVideoToVideoRequestGen4AlephRatio.x960_960,
                _ => null,
            };
        }
    }
}