//HintName: G.Models.StabilityAiTextToImageOptionsEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The engine (model) to use for generating the image. Select from the list of available engines: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`stable-diffusion-xl-1024-v0-9`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`stable-diffusion-xl-1024-v1-0`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`stable-diffusion-v1-6`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`stable-diffusion-512-v2-1`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`stable-diffusion-xl-beta-v2-2-2`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Default Value: stable-diffusion-xl-1024-v1-0<br/>
    /// Example: stable-diffusion-xl-1024-v1-0
    /// </summary>
    public enum StabilityAiTextToImageOptionsEngine
    {
        /// <summary>
        /// 
        /// </summary>
        StableDiffusion512V21,
        /// <summary>
        /// 
        /// </summary>
        StableDiffusionV16,
        /// <summary>
        /// 
        /// </summary>
        StableDiffusionXl1024V09,
        /// <summary>
        /// 
        /// </summary>
        StableDiffusionXl1024V10,
        /// <summary>
        /// 
        /// </summary>
        StableDiffusionXlBetaV222,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StabilityAiTextToImageOptionsEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StabilityAiTextToImageOptionsEngine value)
        {
            return value switch
            {
                StabilityAiTextToImageOptionsEngine.StableDiffusion512V21 => "stable-diffusion-512-v2-1",
                StabilityAiTextToImageOptionsEngine.StableDiffusionV16 => "stable-diffusion-v1-6",
                StabilityAiTextToImageOptionsEngine.StableDiffusionXl1024V09 => "stable-diffusion-xl-1024-v0-9",
                StabilityAiTextToImageOptionsEngine.StableDiffusionXl1024V10 => "stable-diffusion-xl-1024-v1-0",
                StabilityAiTextToImageOptionsEngine.StableDiffusionXlBetaV222 => "stable-diffusion-xl-beta-v2-2-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StabilityAiTextToImageOptionsEngine? ToEnum(string value)
        {
            return value switch
            {
                "stable-diffusion-512-v2-1" => StabilityAiTextToImageOptionsEngine.StableDiffusion512V21,
                "stable-diffusion-v1-6" => StabilityAiTextToImageOptionsEngine.StableDiffusionV16,
                "stable-diffusion-xl-1024-v0-9" => StabilityAiTextToImageOptionsEngine.StableDiffusionXl1024V09,
                "stable-diffusion-xl-1024-v1-0" => StabilityAiTextToImageOptionsEngine.StableDiffusionXl1024V10,
                "stable-diffusion-xl-beta-v2-2-2" => StabilityAiTextToImageOptionsEngine.StableDiffusionXlBetaV222,
                _ => null,
            };
        }
    }
}