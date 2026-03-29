//HintName: G.Models.ChatRequestPluginsItemsOneOf3Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatRequestPluginsItemsOneOf3Id
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file-parser")]
        FileParser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsOneOf3IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsOneOf3Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsOneOf3Id.FileParser => "file-parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsOneOf3Id? ToEnum(string value)
        {
            return value switch
            {
                "file-parser" => ChatRequestPluginsItemsOneOf3Id.FileParser,
                _ => null,
            };
        }
    }
}