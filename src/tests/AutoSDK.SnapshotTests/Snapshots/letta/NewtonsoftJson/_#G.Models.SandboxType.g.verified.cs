//HintName: G.Models.SandboxType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SandboxType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="e2b")]
        E2b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="local")]
        Local,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="modal")]
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