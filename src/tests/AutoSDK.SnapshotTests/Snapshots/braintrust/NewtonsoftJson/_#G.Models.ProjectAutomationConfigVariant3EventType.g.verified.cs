//HintName: G.Models.ProjectAutomationConfigVariant3EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectAutomationConfigVariant3EventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retention")]
        Retention,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant3EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant3EventType value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant3EventType.Retention => "retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant3EventType? ToEnum(string value)
        {
            return value switch
            {
                "retention" => ProjectAutomationConfigVariant3EventType.Retention,
                _ => null,
            };
        }
    }
}