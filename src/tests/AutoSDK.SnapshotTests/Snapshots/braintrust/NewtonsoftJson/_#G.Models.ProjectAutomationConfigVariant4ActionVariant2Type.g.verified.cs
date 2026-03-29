//HintName: G.Models.ProjectAutomationConfigVariant4ActionVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectAutomationConfigVariant4ActionVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack")]
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant4ActionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant4ActionVariant2Type value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant4ActionVariant2Type.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant4ActionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "slack" => ProjectAutomationConfigVariant4ActionVariant2Type.Slack,
                _ => null,
            };
        }
    }
}