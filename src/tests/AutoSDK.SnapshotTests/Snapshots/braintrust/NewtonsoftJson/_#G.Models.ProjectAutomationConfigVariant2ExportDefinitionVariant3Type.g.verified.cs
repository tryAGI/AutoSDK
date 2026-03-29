//HintName: G.Models.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectAutomationConfigVariant2ExportDefinitionVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="btql_query")]
        BtqlQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant2ExportDefinitionVariant3Type value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant2ExportDefinitionVariant3Type.BtqlQuery => "btql_query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant2ExportDefinitionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "btql_query" => ProjectAutomationConfigVariant2ExportDefinitionVariant3Type.BtqlQuery,
                _ => null,
            };
        }
    }
}