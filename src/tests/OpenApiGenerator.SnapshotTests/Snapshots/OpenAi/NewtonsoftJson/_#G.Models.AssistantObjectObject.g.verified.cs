//HintName: G.Models.AssistantObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `assistant`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    public static class AssistantObjectObjectExtensions
    {
        public static string ToValueString(this AssistantObjectObject value)
        {
            return value switch
            {
                AssistantObjectObject.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantObjectObject ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AssistantObjectObject.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => AssistantObjectObject.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}