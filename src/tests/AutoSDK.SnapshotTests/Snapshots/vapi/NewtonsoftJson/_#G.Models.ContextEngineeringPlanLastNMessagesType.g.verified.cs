//HintName: G.Models.ContextEngineeringPlanLastNMessagesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContextEngineeringPlanLastNMessagesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lastNMessages")]
        LastNMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextEngineeringPlanLastNMessagesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextEngineeringPlanLastNMessagesType value)
        {
            return value switch
            {
                ContextEngineeringPlanLastNMessagesType.LastNMessages => "lastNMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextEngineeringPlanLastNMessagesType? ToEnum(string value)
        {
            return value switch
            {
                "lastNMessages" => ContextEngineeringPlanLastNMessagesType.LastNMessages,
                _ => null,
            };
        }
    }
}