//HintName: G.Models.ChatFunctionToolOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatFunctionToolOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFunctionToolOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFunctionToolOneOf0Type value)
        {
            return value switch
            {
                ChatFunctionToolOneOf0Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFunctionToolOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatFunctionToolOneOf0Type.Function,
                _ => null,
            };
        }
    }
}