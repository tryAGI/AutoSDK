//HintName: G.Models.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="log_traces")]
        LogTraces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type.LogTraces => "log_traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "log_traces" => PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type.LogTraces,
                _ => null,
            };
        }
    }
}