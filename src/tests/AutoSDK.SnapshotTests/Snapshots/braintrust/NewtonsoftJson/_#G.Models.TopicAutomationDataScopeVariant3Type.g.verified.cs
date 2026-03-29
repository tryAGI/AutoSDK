//HintName: G.Models.TopicAutomationDataScopeVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TopicAutomationDataScopeVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicAutomationDataScopeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicAutomationDataScopeVariant3Type value)
        {
            return value switch
            {
                TopicAutomationDataScopeVariant3Type.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicAutomationDataScopeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => TopicAutomationDataScopeVariant3Type.Experiment,
                _ => null,
            };
        }
    }
}