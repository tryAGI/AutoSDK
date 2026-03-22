//HintName: G.Models.CreateImageToVideoRequestGen4TurboRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageToVideoRequestGen4TurboRatio
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
        [global::System.Runtime.Serialization.EnumMember(Value="960:960")]
        x960_960,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestGen4TurboRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestGen4TurboRatio value)
        {
            return value switch
            {
                CreateImageToVideoRequestGen4TurboRatio.x1104_832 => "1104:832",
                CreateImageToVideoRequestGen4TurboRatio.x1280_720 => "1280:720",
                CreateImageToVideoRequestGen4TurboRatio.x1584_672 => "1584:672",
                CreateImageToVideoRequestGen4TurboRatio.x720_1280 => "720:1280",
                CreateImageToVideoRequestGen4TurboRatio.x832_1104 => "832:1104",
                CreateImageToVideoRequestGen4TurboRatio.x960_960 => "960:960",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestGen4TurboRatio? ToEnum(string value)
        {
            return value switch
            {
                "1104:832" => CreateImageToVideoRequestGen4TurboRatio.x1104_832,
                "1280:720" => CreateImageToVideoRequestGen4TurboRatio.x1280_720,
                "1584:672" => CreateImageToVideoRequestGen4TurboRatio.x1584_672,
                "720:1280" => CreateImageToVideoRequestGen4TurboRatio.x720_1280,
                "832:1104" => CreateImageToVideoRequestGen4TurboRatio.x832_1104,
                "960:960" => CreateImageToVideoRequestGen4TurboRatio.x960_960,
                _ => null,
            };
        }
    }
}