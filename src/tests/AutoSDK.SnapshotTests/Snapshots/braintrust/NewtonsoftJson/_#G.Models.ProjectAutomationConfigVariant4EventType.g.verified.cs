//HintName: G.Models.ProjectAutomationConfigVariant4EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectAutomationConfigVariant4EventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="environment_update")]
        EnvironmentUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant4EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant4EventType value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant4EventType.EnvironmentUpdate => "environment_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant4EventType? ToEnum(string value)
        {
            return value switch
            {
                "environment_update" => ProjectAutomationConfigVariant4EventType.EnvironmentUpdate,
                _ => null,
            };
        }
    }
}