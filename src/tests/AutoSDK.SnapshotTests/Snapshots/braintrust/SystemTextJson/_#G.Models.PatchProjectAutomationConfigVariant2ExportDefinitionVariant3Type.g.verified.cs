//HintName: G.Models.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        BtqlQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type.BtqlQuery => "btql_query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "btql_query" => PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type.BtqlQuery,
                _ => null,
            };
        }
    }
}