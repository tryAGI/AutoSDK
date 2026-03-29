//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status value)
        {
            return value switch
            {
                EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status.Error => "error",
                EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "error" => EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status.Error,
                "success" => EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status.Success,
                _ => null,
            };
        }
    }
}