//HintName: G.Models.CreateTextToVideoRequestModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model to use for generation.<br/>
    /// Default Value: kling-v1
    /// </summary>
    public enum CreateTextToVideoRequestModelName
    {
        /// <summary>
        /// 
        /// </summary>
        KlingV1,
        /// <summary>
        /// 
        /// </summary>
        KlingV15,
        /// <summary>
        /// 
        /// </summary>
        KlingV16,
        /// <summary>
        /// 
        /// </summary>
        KlingV2,
        /// <summary>
        /// 
        /// </summary>
        KlingV21,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestModelName value)
        {
            return value switch
            {
                CreateTextToVideoRequestModelName.KlingV1 => "kling-v1",
                CreateTextToVideoRequestModelName.KlingV15 => "kling-v1-5",
                CreateTextToVideoRequestModelName.KlingV16 => "kling-v1-6",
                CreateTextToVideoRequestModelName.KlingV2 => "kling-v2",
                CreateTextToVideoRequestModelName.KlingV21 => "kling-v2-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "kling-v1" => CreateTextToVideoRequestModelName.KlingV1,
                "kling-v1-5" => CreateTextToVideoRequestModelName.KlingV15,
                "kling-v1-6" => CreateTextToVideoRequestModelName.KlingV16,
                "kling-v2" => CreateTextToVideoRequestModelName.KlingV2,
                "kling-v2-1" => CreateTextToVideoRequestModelName.KlingV21,
                _ => null,
            };
        }
    }
}