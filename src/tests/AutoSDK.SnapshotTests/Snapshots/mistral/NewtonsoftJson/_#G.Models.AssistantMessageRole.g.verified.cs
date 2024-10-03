//HintName: G.Models.AssistantMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: assistant
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantMessageRole
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
    public static class AssistantMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageRole value)
        {
            return value switch
            {
                AssistantMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AssistantMessageRole.Assistant,
                _ => null,
            };
        }
    }
}