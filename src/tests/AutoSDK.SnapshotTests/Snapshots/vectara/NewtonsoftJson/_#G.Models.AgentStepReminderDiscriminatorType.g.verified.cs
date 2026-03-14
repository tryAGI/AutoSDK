//HintName: G.Models.AgentStepReminderDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentStepReminderDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="templated")]
        Templated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentStepReminderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentStepReminderDiscriminatorType value)
        {
            return value switch
            {
                AgentStepReminderDiscriminatorType.Templated => "templated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentStepReminderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "templated" => AgentStepReminderDiscriminatorType.Templated,
                _ => null,
            };
        }
    }
}