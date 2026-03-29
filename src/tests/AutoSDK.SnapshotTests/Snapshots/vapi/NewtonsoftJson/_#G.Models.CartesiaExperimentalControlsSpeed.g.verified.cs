//HintName: G.Models.CartesiaExperimentalControlsSpeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: normal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CartesiaExperimentalControlsSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fastest")]
        Fastest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="normal")]
        Normal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slow")]
        Slow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slowest")]
        Slowest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaExperimentalControlsSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaExperimentalControlsSpeed value)
        {
            return value switch
            {
                CartesiaExperimentalControlsSpeed.Fast => "fast",
                CartesiaExperimentalControlsSpeed.Fastest => "fastest",
                CartesiaExperimentalControlsSpeed.Normal => "normal",
                CartesiaExperimentalControlsSpeed.Slow => "slow",
                CartesiaExperimentalControlsSpeed.Slowest => "slowest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaExperimentalControlsSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => CartesiaExperimentalControlsSpeed.Fast,
                "fastest" => CartesiaExperimentalControlsSpeed.Fastest,
                "normal" => CartesiaExperimentalControlsSpeed.Normal,
                "slow" => CartesiaExperimentalControlsSpeed.Slow,
                "slowest" => CartesiaExperimentalControlsSpeed.Slowest,
                _ => null,
            };
        }
    }
}