//HintName: G.Models.PatchProjectAutomationConfigVariant4EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum PatchProjectAutomationConfigVariant4EventType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant4EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant4EventType value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant4EventType.EnvironmentUpdate => "environment_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant4EventType? ToEnum(string value)
        {
            return value switch
            {
                "environment_update" => PatchProjectAutomationConfigVariant4EventType.EnvironmentUpdate,
                _ => null,
            };
        }
    }
}