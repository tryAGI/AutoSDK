//HintName: G.Models.ContextEngineeringPlanUserAndAssistantMessagesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContextEngineeringPlanUserAndAssistantMessagesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="userAndAssistantMessages")]
        UserAndAssistantMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextEngineeringPlanUserAndAssistantMessagesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextEngineeringPlanUserAndAssistantMessagesType value)
        {
            return value switch
            {
                ContextEngineeringPlanUserAndAssistantMessagesType.UserAndAssistantMessages => "userAndAssistantMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextEngineeringPlanUserAndAssistantMessagesType? ToEnum(string value)
        {
            return value switch
            {
                "userAndAssistantMessages" => ContextEngineeringPlanUserAndAssistantMessagesType.UserAndAssistantMessages,
                _ => null,
            };
        }
    }
}