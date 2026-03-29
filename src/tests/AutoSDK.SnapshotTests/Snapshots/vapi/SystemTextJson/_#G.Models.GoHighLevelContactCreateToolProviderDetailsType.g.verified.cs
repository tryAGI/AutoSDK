//HintName: G.Models.GoHighLevelContactCreateToolProviderDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.create" for GoHighLevel contact create tool.
    /// </summary>
    public enum GoHighLevelContactCreateToolProviderDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        GohighlevelContactCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoHighLevelContactCreateToolProviderDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelContactCreateToolProviderDetailsType value)
        {
            return value switch
            {
                GoHighLevelContactCreateToolProviderDetailsType.GohighlevelContactCreate => "gohighlevel.contact.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelContactCreateToolProviderDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.create" => GoHighLevelContactCreateToolProviderDetailsType.GohighlevelContactCreate,
                _ => null,
            };
        }
    }
}