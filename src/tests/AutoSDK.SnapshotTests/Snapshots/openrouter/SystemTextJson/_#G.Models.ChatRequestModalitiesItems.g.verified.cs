//HintName: G.Models.ChatRequestModalitiesItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestModalitiesItems
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestModalitiesItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestModalitiesItems value)
        {
            return value switch
            {
                ChatRequestModalitiesItems.Audio => "audio",
                ChatRequestModalitiesItems.Image => "image",
                ChatRequestModalitiesItems.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestModalitiesItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ChatRequestModalitiesItems.Audio,
                "image" => ChatRequestModalitiesItems.Image,
                "text" => ChatRequestModalitiesItems.Text,
                _ => null,
            };
        }
    }
}