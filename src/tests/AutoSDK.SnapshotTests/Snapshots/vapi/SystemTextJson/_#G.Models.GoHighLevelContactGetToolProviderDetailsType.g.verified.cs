//HintName: G.Models.GoHighLevelContactGetToolProviderDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.get" for GoHighLevel contact get tool.
    /// </summary>
    public enum GoHighLevelContactGetToolProviderDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        GohighlevelContactGet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoHighLevelContactGetToolProviderDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelContactGetToolProviderDetailsType value)
        {
            return value switch
            {
                GoHighLevelContactGetToolProviderDetailsType.GohighlevelContactGet => "gohighlevel.contact.get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelContactGetToolProviderDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.get" => GoHighLevelContactGetToolProviderDetailsType.GohighlevelContactGet,
                _ => null,
            };
        }
    }
}