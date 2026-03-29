//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnvironmentsSendMessageRequestMessageVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approval")]
        Approval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentsSendMessageRequestMessageVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsSendMessageRequestMessageVariant2Type value)
        {
            return value switch
            {
                EnvironmentsSendMessageRequestMessageVariant2Type.Approval => "approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsSendMessageRequestMessageVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "approval" => EnvironmentsSendMessageRequestMessageVariant2Type.Approval,
                _ => null,
            };
        }
    }
}