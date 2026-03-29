//HintName: G.Models.LocalRunnerStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalRunnerStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
        /// <summary>
        /// 
        /// </summary>
        Disconnected,
        /// <summary>
        /// 
        /// </summary>
        Pairing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalRunnerStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalRunnerStatus value)
        {
            return value switch
            {
                LocalRunnerStatus.Connected => "connected",
                LocalRunnerStatus.Disconnected => "disconnected",
                LocalRunnerStatus.Pairing => "pairing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalRunnerStatus? ToEnum(string value)
        {
            return value switch
            {
                "connected" => LocalRunnerStatus.Connected,
                "disconnected" => LocalRunnerStatus.Disconnected,
                "pairing" => LocalRunnerStatus.Pairing,
                _ => null,
            };
        }
    }
}