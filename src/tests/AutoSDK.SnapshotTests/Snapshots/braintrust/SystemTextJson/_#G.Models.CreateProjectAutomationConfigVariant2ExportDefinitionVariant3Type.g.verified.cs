//HintName: G.Models.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        BtqlQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type.BtqlQuery => "btql_query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "btql_query" => CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type.BtqlQuery,
                _ => null,
            };
        }
    }
}