//HintName: G.Models.ProjectAutomationConfigVariant4ActionVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectAutomationConfigVariant4ActionVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant4ActionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant4ActionVariant1Type value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant4ActionVariant1Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant4ActionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ProjectAutomationConfigVariant4ActionVariant1Type.Webhook,
                _ => null,
            };
        }
    }
}