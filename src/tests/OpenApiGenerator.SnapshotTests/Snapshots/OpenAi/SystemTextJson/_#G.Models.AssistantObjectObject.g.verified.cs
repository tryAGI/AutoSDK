//HintName: G.Models.AssistantObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `assistant`.
    /// </summary>
    public enum AssistantObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantObjectObject value)
        {
            return value switch
            {
                AssistantObjectObject.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantObjectObject ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AssistantObjectObject.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}