//HintName: G.Models.SandboxState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the sandbox
    /// </summary>
    public enum SandboxState
    {
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxState value)
        {
            return value switch
            {
                SandboxState.Paused => "paused",
                SandboxState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxState? ToEnum(string value)
        {
            return value switch
            {
                "paused" => SandboxState.Paused,
                "running" => SandboxState.Running,
                _ => null,
            };
        }
    }
}