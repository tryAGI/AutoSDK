//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "all" => MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type.All,
                _ => null,
            };
        }
    }
}