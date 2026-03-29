//HintName: G.Models.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType
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
    public static class ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType.Approval => "approval",
                ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "approval" => ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType.Approval,
                "tool" => ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType.Tool,
                _ => null,
            };
        }
    }
}