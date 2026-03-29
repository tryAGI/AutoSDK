//HintName: G.Models.EvalRunTargetAssistantType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the target.<br/>
    /// Currently it is fixed to `assistant`.<br/>
    /// Example: assistant
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalRunTargetAssistantType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunTargetAssistantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunTargetAssistantType value)
        {
            return value switch
            {
                EvalRunTargetAssistantType.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunTargetAssistantType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => EvalRunTargetAssistantType.Assistant,
                _ => null,
            };
        }
    }
}