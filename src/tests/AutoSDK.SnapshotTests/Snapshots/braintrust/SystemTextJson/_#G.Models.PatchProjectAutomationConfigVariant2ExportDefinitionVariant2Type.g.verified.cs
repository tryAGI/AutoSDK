//HintName: G.Models.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        LogSpans,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type.LogSpans => "log_spans",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "log_spans" => PatchProjectAutomationConfigVariant2ExportDefinitionVariant2Type.LogSpans,
                _ => null,
            };
        }
    }
}