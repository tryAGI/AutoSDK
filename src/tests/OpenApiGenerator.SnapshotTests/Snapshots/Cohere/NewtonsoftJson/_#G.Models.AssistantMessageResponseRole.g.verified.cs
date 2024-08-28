//HintName: G.Models.AssistantMessageResponseRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantMessageResponseRole
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
    public static class AssistantMessageResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMessageResponseRole value)
        {
            return value switch
            {
                AssistantMessageResponseRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMessageResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AssistantMessageResponseRole.Assistant,
                _ => null,
            };
        }
    }
}