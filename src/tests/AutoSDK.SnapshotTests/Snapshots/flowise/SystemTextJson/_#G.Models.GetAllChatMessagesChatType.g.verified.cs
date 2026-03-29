//HintName: G.Models.GetAllChatMessagesChatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChatMessagesChatType
    {
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllChatMessagesChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChatMessagesChatType value)
        {
            return value switch
            {
                GetAllChatMessagesChatType.External => "EXTERNAL",
                GetAllChatMessagesChatType.Internal => "INTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChatMessagesChatType? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => GetAllChatMessagesChatType.External,
                "INTERNAL" => GetAllChatMessagesChatType.Internal,
                _ => null,
            };
        }
    }
}