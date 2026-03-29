//HintName: G.Models.CreateImageGenerationRequestModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model to use for generation.<br/>
    /// Default Value: kling-v1
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageGenerationRequestModelName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kling-v1")]
        KlingV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kling-v1-5")]
        KlingV15,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kling-v2")]
        KlingV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageGenerationRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageGenerationRequestModelName value)
        {
            return value switch
            {
                CreateImageGenerationRequestModelName.KlingV1 => "kling-v1",
                CreateImageGenerationRequestModelName.KlingV15 => "kling-v1-5",
                CreateImageGenerationRequestModelName.KlingV2 => "kling-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageGenerationRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "kling-v1" => CreateImageGenerationRequestModelName.KlingV1,
                "kling-v1-5" => CreateImageGenerationRequestModelName.KlingV15,
                "kling-v2" => CreateImageGenerationRequestModelName.KlingV2,
                _ => null,
            };
        }
    }
}