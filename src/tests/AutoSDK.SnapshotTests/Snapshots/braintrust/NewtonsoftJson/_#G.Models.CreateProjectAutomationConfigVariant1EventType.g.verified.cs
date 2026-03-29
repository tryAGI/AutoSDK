//HintName: G.Models.CreateProjectAutomationConfigVariant1EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateProjectAutomationConfigVariant1EventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logs")]
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant1EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant1EventType value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant1EventType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant1EventType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => CreateProjectAutomationConfigVariant1EventType.Logs,
                _ => null,
            };
        }
    }
}