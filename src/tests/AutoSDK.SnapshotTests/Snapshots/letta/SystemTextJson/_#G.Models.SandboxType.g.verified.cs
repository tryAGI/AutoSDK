//HintName: G.Models.SandboxType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxType
    {
        /// <summary>
        /// 
        /// </summary>
        E2b,
        /// <summary>
        /// 
        /// </summary>
        Local,
        /// <summary>
        /// 
        /// </summary>
        Modal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxType value)
        {
            return value switch
            {
                SandboxType.E2b => "e2b",
                SandboxType.Local => "local",
                SandboxType.Modal => "modal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxType? ToEnum(string value)
        {
            return value switch
            {
                "e2b" => SandboxType.E2b,
                "local" => SandboxType.Local,
                "modal" => SandboxType.Modal,
                _ => null,
            };
        }
    }
}