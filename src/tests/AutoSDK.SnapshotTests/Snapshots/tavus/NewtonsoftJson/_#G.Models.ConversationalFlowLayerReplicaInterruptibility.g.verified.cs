//HintName: G.Models.ConversationalFlowLayerReplicaInterruptibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationalFlowLayerReplicaInterruptibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationalFlowLayerReplicaInterruptibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationalFlowLayerReplicaInterruptibility value)
        {
            return value switch
            {
                ConversationalFlowLayerReplicaInterruptibility.High => "high",
                ConversationalFlowLayerReplicaInterruptibility.Low => "low",
                ConversationalFlowLayerReplicaInterruptibility.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationalFlowLayerReplicaInterruptibility? ToEnum(string value)
        {
            return value switch
            {
                "high" => ConversationalFlowLayerReplicaInterruptibility.High,
                "low" => ConversationalFlowLayerReplicaInterruptibility.Low,
                "medium" => ConversationalFlowLayerReplicaInterruptibility.Medium,
                _ => null,
            };
        }
    }
}