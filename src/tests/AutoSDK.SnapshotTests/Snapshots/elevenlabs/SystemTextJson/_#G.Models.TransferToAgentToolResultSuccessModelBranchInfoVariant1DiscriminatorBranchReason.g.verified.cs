//HintName: G.Models.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason
    {
        /// <summary>
        /// 
        /// </summary>
        DefaultingToMain,
        /// <summary>
        /// 
        /// </summary>
        TrafficSplit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason value)
        {
            return value switch
            {
                TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain => "defaulting_to_main",
                TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit => "traffic_split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason? ToEnum(string value)
        {
            return value switch
            {
                "defaulting_to_main" => TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain,
                "traffic_split" => TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit,
                _ => null,
            };
        }
    }
}