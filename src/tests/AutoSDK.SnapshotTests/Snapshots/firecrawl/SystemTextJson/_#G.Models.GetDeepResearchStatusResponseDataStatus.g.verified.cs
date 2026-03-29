//HintName: G.Models.GetDeepResearchStatusResponseDataStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeepResearchStatusResponseDataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeepResearchStatusResponseDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeepResearchStatusResponseDataStatus value)
        {
            return value switch
            {
                GetDeepResearchStatusResponseDataStatus.Completed => "completed",
                GetDeepResearchStatusResponseDataStatus.Failed => "failed",
                GetDeepResearchStatusResponseDataStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeepResearchStatusResponseDataStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetDeepResearchStatusResponseDataStatus.Completed,
                "failed" => GetDeepResearchStatusResponseDataStatus.Failed,
                "processing" => GetDeepResearchStatusResponseDataStatus.Processing,
                _ => null,
            };
        }
    }
}