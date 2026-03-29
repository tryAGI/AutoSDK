//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type value)
        {
            return value switch
            {
                EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "tool" => EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type.Tool,
                _ => null,
            };
        }
    }
}