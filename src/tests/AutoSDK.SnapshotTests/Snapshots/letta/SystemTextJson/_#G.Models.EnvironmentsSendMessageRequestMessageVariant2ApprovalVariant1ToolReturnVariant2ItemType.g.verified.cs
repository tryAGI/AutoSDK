//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType value)
        {
            return value switch
            {
                EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType? ToEnum(string value)
        {
            return value switch
            {
                "text" => EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType.Text,
                _ => null,
            };
        }
    }
}