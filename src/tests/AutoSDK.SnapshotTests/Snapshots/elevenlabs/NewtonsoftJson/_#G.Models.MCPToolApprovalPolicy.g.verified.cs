//HintName: G.Models.MCPToolApprovalPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the tool-level approval policy.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MCPToolApprovalPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto_approved")]
        AutoApproved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requires_approval")]
        RequiresApproval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolApprovalPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolApprovalPolicy value)
        {
            return value switch
            {
                MCPToolApprovalPolicy.AutoApproved => "auto_approved",
                MCPToolApprovalPolicy.RequiresApproval => "requires_approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolApprovalPolicy? ToEnum(string value)
        {
            return value switch
            {
                "auto_approved" => MCPToolApprovalPolicy.AutoApproved,
                "requires_approval" => MCPToolApprovalPolicy.RequiresApproval,
                _ => null,
            };
        }
    }
}