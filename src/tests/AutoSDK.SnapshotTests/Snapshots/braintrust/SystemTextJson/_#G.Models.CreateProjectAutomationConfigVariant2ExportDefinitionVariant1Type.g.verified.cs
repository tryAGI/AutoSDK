//HintName: G.Models.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        LogTraces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type.LogTraces => "log_traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "log_traces" => CreateProjectAutomationConfigVariant2ExportDefinitionVariant1Type.LogTraces,
                _ => null,
            };
        }
    }
}