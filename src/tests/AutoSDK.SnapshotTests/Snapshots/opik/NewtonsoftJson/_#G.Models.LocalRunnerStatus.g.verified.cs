//HintName: G.Models.LocalRunnerStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalRunnerStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="connected")]
        Connected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disconnected")]
        Disconnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pairing")]
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