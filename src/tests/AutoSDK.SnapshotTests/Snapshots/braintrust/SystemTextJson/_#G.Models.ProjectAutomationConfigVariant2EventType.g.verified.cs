//HintName: G.Models.ProjectAutomationConfigVariant2EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum ProjectAutomationConfigVariant2EventType
    {
        /// <summary>
        /// 
        /// </summary>
        BtqlExport,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant2EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant2EventType value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant2EventType.BtqlExport => "btql_export",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant2EventType? ToEnum(string value)
        {
            return value switch
            {
                "btql_export" => ProjectAutomationConfigVariant2EventType.BtqlExport,
                _ => null,
            };
        }
    }
}