//HintName: G.Models.GoHighLevelContactGetToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.get" for GoHighLevel Contact Get tool.
    /// </summary>
    public enum GoHighLevelContactGetToolType
    {
        /// <summary>
        /// 
        /// </summary>
        GohighlevelContactGet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoHighLevelContactGetToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelContactGetToolType value)
        {
            return value switch
            {
                GoHighLevelContactGetToolType.GohighlevelContactGet => "gohighlevel.contact.get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelContactGetToolType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.get" => GoHighLevelContactGetToolType.GohighlevelContactGet,
                _ => null,
            };
        }
    }
}