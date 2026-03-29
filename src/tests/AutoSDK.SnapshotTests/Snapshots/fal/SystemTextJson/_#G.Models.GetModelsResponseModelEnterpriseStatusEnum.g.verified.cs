//HintName: G.Models.GetModelsResponseModelEnterpriseStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 'ready' means approved for enterprise use, 'pending' means awaiting approval
    /// </summary>
    public enum GetModelsResponseModelEnterpriseStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsResponseModelEnterpriseStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseModelEnterpriseStatusEnum value)
        {
            return value switch
            {
                GetModelsResponseModelEnterpriseStatusEnum.Pending => "pending",
                GetModelsResponseModelEnterpriseStatusEnum.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseModelEnterpriseStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "pending" => GetModelsResponseModelEnterpriseStatusEnum.Pending,
                "ready" => GetModelsResponseModelEnterpriseStatusEnum.Ready,
                _ => null,
            };
        }
    }
}