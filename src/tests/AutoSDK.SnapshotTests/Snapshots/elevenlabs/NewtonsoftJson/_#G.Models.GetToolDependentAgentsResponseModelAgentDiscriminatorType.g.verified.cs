//HintName: G.Models.GetToolDependentAgentsResponseModelAgentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetToolDependentAgentsResponseModelAgentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="available")]
        Available,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolDependentAgentsResponseModelAgentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolDependentAgentsResponseModelAgentDiscriminatorType value)
        {
            return value switch
            {
                GetToolDependentAgentsResponseModelAgentDiscriminatorType.Available => "available",
                GetToolDependentAgentsResponseModelAgentDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolDependentAgentsResponseModelAgentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetToolDependentAgentsResponseModelAgentDiscriminatorType.Available,
                "unknown" => GetToolDependentAgentsResponseModelAgentDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}