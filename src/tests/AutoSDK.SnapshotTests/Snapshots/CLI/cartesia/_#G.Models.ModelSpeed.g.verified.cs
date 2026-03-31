//HintName: G.Models.ModelSpeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use `generation_config.speed` for sonic-3.<br/>
    /// Speed setting for the model. Defaults to `normal`.<br/>
    /// This feature is experimental and may not work for all voices.<br/>
    /// Influences the speed of the generated speech. Faster speeds may reduce hallucination rate.<br/>
    /// Default Value: normal
    /// </summary>
    public enum ModelSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Slow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelSpeed value)
        {
            return value switch
            {
                ModelSpeed.Fast => "fast",
                ModelSpeed.Normal => "normal",
                ModelSpeed.Slow => "slow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => ModelSpeed.Fast,
                "normal" => ModelSpeed.Normal,
                "slow" => ModelSpeed.Slow,
                _ => null,
            };
        }
    }
}