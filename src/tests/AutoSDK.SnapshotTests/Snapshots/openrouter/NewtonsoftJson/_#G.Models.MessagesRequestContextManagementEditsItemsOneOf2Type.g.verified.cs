//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestContextManagementEditsItemsOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="compact_20260112")]
        Compact20260112,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf2Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf2Type.Compact20260112 => "compact_20260112",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "compact_20260112" => MessagesRequestContextManagementEditsItemsOneOf2Type.Compact20260112,
                _ => null,
            };
        }
    }
}