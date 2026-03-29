//HintName: G.Models.ListExportRequestsV2ResponseItemChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListExportRequestsV2ResponseItemChannel
    {
        /// <summary>
        /// 
        /// </summary>
        Call,
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExportRequestsV2ResponseItemChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportRequestsV2ResponseItemChannel value)
        {
            return value switch
            {
                ListExportRequestsV2ResponseItemChannel.Call => "call",
                ListExportRequestsV2ResponseItemChannel.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportRequestsV2ResponseItemChannel? ToEnum(string value)
        {
            return value switch
            {
                "call" => ListExportRequestsV2ResponseItemChannel.Call,
                "chat" => ListExportRequestsV2ResponseItemChannel.Chat,
                _ => null,
            };
        }
    }
}