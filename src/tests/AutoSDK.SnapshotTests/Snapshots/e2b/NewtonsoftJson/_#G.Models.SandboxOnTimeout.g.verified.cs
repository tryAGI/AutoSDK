//HintName: G.Models.SandboxOnTimeout.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Action taken when the sandbox times out.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SandboxOnTimeout
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kill")]
        Kill,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pause")]
        Pause,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxOnTimeoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxOnTimeout value)
        {
            return value switch
            {
                SandboxOnTimeout.Kill => "kill",
                SandboxOnTimeout.Pause => "pause",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxOnTimeout? ToEnum(string value)
        {
            return value switch
            {
                "kill" => SandboxOnTimeout.Kill,
                "pause" => SandboxOnTimeout.Pause,
                _ => null,
            };
        }
    }
}