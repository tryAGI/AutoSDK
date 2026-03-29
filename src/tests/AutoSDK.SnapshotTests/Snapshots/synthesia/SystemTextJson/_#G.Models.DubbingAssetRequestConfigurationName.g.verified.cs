//HintName: G.Models.DubbingAssetRequestConfigurationName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: dubbing
    /// </summary>
    public enum DubbingAssetRequestConfigurationName
    {
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbingAssetRequestConfigurationNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbingAssetRequestConfigurationName value)
        {
            return value switch
            {
                DubbingAssetRequestConfigurationName.Dubbing => "dubbing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbingAssetRequestConfigurationName? ToEnum(string value)
        {
            return value switch
            {
                "dubbing" => DubbingAssetRequestConfigurationName.Dubbing,
                _ => null,
            };
        }
    }
}