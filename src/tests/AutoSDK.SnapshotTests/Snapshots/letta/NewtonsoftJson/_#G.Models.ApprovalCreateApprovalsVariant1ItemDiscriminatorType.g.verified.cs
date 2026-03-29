//HintName: G.Models.ApprovalCreateApprovalsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApprovalCreateApprovalsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approval")]
        Approval,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApprovalCreateApprovalsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Approval => "approval",
                ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApprovalCreateApprovalsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "approval" => ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Approval,
                "tool" => ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Tool,
                _ => null,
            };
        }
    }
}