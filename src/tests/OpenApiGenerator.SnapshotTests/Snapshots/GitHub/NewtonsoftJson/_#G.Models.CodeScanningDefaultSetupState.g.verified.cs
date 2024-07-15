//HintName: G.Models.CodeScanningDefaultSetupState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code scanning default setup has been configured or not.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningDefaultSetupState
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
    public static class CodeScanningDefaultSetupStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupState value)
        {
            return value switch
            {
                CodeScanningDefaultSetupState.Configured => "configured",
                CodeScanningDefaultSetupState.NotConfigured => "not-configured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupState? ToEnum(string value)
        {
            return value switch
            {
                "configured" => CodeScanningDefaultSetupState.Configured,
                "not-configured" => CodeScanningDefaultSetupState.NotConfigured,
                _ => null,
            };
        }
    }
}