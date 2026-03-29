//HintName: G.Models.GoHighLevelContactGetToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.get" for GoHighLevel Contact Get tool.
    /// </summary>
    public enum GoHighLevelContactGetToolWithToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        GohighlevelContactGet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoHighLevelContactGetToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelContactGetToolWithToolCallType value)
        {
            return value switch
            {
                GoHighLevelContactGetToolWithToolCallType.GohighlevelContactGet => "gohighlevel.contact.get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelContactGetToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.get" => GoHighLevelContactGetToolWithToolCallType.GohighlevelContactGet,
                _ => null,
            };
        }
    }
}