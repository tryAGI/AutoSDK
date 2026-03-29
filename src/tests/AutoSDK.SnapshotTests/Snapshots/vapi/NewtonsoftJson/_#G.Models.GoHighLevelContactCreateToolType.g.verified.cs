//HintName: G.Models.GoHighLevelContactCreateToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.create" for GoHighLevel Contact Create tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoHighLevelContactCreateToolType
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
    public static class GoHighLevelContactCreateToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelContactCreateToolType value)
        {
            return value switch
            {
                GoHighLevelContactCreateToolType.GohighlevelContactCreate => "gohighlevel.contact.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelContactCreateToolType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.create" => GoHighLevelContactCreateToolType.GohighlevelContactCreate,
                _ => null,
            };
        }
    }
}