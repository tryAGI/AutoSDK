//HintName: G.Models.ProjectAutomationConfigVariant1EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum ProjectAutomationConfigVariant1EventType
    {
        /// <summary>
        /// 
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant1EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant1EventType value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant1EventType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant1EventType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => ProjectAutomationConfigVariant1EventType.Logs,
                _ => null,
            };
        }
    }
}