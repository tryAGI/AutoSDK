//HintName: G.Models.MessagesOutputConfigEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer. Valid values are `low`, `medium`, `high`, or `max`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesOutputConfigEffort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max")]
        Max,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesOutputConfigEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesOutputConfigEffort value)
        {
            return value switch
            {
                MessagesOutputConfigEffort.High => "high",
                MessagesOutputConfigEffort.Low => "low",
                MessagesOutputConfigEffort.Max => "max",
                MessagesOutputConfigEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesOutputConfigEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => MessagesOutputConfigEffort.High,
                "low" => MessagesOutputConfigEffort.Low,
                "max" => MessagesOutputConfigEffort.Max,
                "medium" => MessagesOutputConfigEffort.Medium,
                _ => null,
            };
        }
    }
}