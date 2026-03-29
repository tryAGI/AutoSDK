//HintName: G.Models.CreateImageToVideoRequestModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model to use for generation.<br/>
    /// Default Value: kling-v1
    /// </summary>
    public enum CreateImageToVideoRequestModelName
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
    public static class CreateImageToVideoRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestModelName value)
        {
            return value switch
            {
                CreateImageToVideoRequestModelName.KlingV1 => "kling-v1",
                CreateImageToVideoRequestModelName.KlingV15 => "kling-v1-5",
                CreateImageToVideoRequestModelName.KlingV16 => "kling-v1-6",
                CreateImageToVideoRequestModelName.KlingV2 => "kling-v2",
                CreateImageToVideoRequestModelName.KlingV21 => "kling-v2-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "kling-v1" => CreateImageToVideoRequestModelName.KlingV1,
                "kling-v1-5" => CreateImageToVideoRequestModelName.KlingV15,
                "kling-v1-6" => CreateImageToVideoRequestModelName.KlingV16,
                "kling-v2" => CreateImageToVideoRequestModelName.KlingV2,
                "kling-v2-1" => CreateImageToVideoRequestModelName.KlingV21,
                _ => null,
            };
        }
    }
}