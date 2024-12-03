//HintName: G.Models.CodeScanningDefaultSetupUpdateState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The desired state of code scanning default setup.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningDefaultSetupUpdateState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="configured")]
        Configured,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not-configured")]
        NotConfigured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupUpdateStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupUpdateState value)
        {
            return value switch
            {
                CodeScanningDefaultSetupUpdateState.Configured => "configured",
                CodeScanningDefaultSetupUpdateState.NotConfigured => "not-configured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupUpdateState? ToEnum(string value)
        {
            return value switch
            {
                "configured" => CodeScanningDefaultSetupUpdateState.Configured,
                "not-configured" => CodeScanningDefaultSetupUpdateState.NotConfigured,
                _ => null,
            };
        }
    }
}