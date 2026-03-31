//HintName: G.Models.PatchProjectAutomationConfigVariant1EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum PatchProjectAutomationConfigVariant1EventType
    {
        /// <summary>
        /// 
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant1EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant1EventType value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant1EventType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant1EventType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => PatchProjectAutomationConfigVariant1EventType.Logs,
                _ => null,
            };
        }
    }
}