//HintName: G.Models.GoHighLevelContactCreateToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.create" for GoHighLevel Contact Create tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoHighLevelContactCreateToolWithToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel.contact.create")]
        GohighlevelContactCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoHighLevelContactCreateToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelContactCreateToolWithToolCallType value)
        {
            return value switch
            {
                GoHighLevelContactCreateToolWithToolCallType.GohighlevelContactCreate => "gohighlevel.contact.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelContactCreateToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.create" => GoHighLevelContactCreateToolWithToolCallType.GohighlevelContactCreate,
                _ => null,
            };
        }
    }
}