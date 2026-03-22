//HintName: G.Models.CreateCharacterPerformanceRequestActTwoRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Example: 1280:720
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCharacterPerformanceRequestActTwoRatio
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
    public static class CreateCharacterPerformanceRequestActTwoRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCharacterPerformanceRequestActTwoRatio value)
        {
            return value switch
            {
                CreateCharacterPerformanceRequestActTwoRatio.x1104_832 => "1104:832",
                CreateCharacterPerformanceRequestActTwoRatio.x1280_720 => "1280:720",
                CreateCharacterPerformanceRequestActTwoRatio.x1584_672 => "1584:672",
                CreateCharacterPerformanceRequestActTwoRatio.x720_1280 => "720:1280",
                CreateCharacterPerformanceRequestActTwoRatio.x832_1104 => "832:1104",
                CreateCharacterPerformanceRequestActTwoRatio.x960_960 => "960:960",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCharacterPerformanceRequestActTwoRatio? ToEnum(string value)
        {
            return value switch
            {
                "1104:832" => CreateCharacterPerformanceRequestActTwoRatio.x1104_832,
                "1280:720" => CreateCharacterPerformanceRequestActTwoRatio.x1280_720,
                "1584:672" => CreateCharacterPerformanceRequestActTwoRatio.x1584_672,
                "720:1280" => CreateCharacterPerformanceRequestActTwoRatio.x720_1280,
                "832:1104" => CreateCharacterPerformanceRequestActTwoRatio.x832_1104,
                "960:960" => CreateCharacterPerformanceRequestActTwoRatio.x960_960,
                _ => null,
            };
        }
    }
}