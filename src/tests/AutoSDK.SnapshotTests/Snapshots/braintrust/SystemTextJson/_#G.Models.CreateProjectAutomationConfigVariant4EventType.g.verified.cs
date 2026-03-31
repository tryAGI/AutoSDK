//HintName: G.Models.CreateProjectAutomationConfigVariant4EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum CreateProjectAutomationConfigVariant4EventType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant4EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant4EventType value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant4EventType.EnvironmentUpdate => "environment_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant4EventType? ToEnum(string value)
        {
            return value switch
            {
                "environment_update" => CreateProjectAutomationConfigVariant4EventType.EnvironmentUpdate,
                _ => null,
            };
        }
    }
}