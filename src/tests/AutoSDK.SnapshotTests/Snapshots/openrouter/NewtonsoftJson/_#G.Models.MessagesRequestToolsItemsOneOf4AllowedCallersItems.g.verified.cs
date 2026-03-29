//HintName: G.Models.MessagesRequestToolsItemsOneOf4AllowedCallersItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestToolsItemsOneOf4AllowedCallersItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution_20250825")]
        CodeExecution20250825,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_execution_20260120")]
        CodeExecution20260120,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="direct")]
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf4AllowedCallersItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf4AllowedCallersItems value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf4AllowedCallersItems.CodeExecution20250825 => "code_execution_20250825",
                MessagesRequestToolsItemsOneOf4AllowedCallersItems.CodeExecution20260120 => "code_execution_20260120",
                MessagesRequestToolsItemsOneOf4AllowedCallersItems.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf4AllowedCallersItems? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_20250825" => MessagesRequestToolsItemsOneOf4AllowedCallersItems.CodeExecution20250825,
                "code_execution_20260120" => MessagesRequestToolsItemsOneOf4AllowedCallersItems.CodeExecution20260120,
                "direct" => MessagesRequestToolsItemsOneOf4AllowedCallersItems.Direct,
                _ => null,
            };
        }
    }
}