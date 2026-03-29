//HintName: G.Models.GetResearchResponseDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetResearchResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResearchResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResearchResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetResearchResponseDiscriminatorStatus.Completed => "completed",
                GetResearchResponseDiscriminatorStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResearchResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetResearchResponseDiscriminatorStatus.Completed,
                "failed" => GetResearchResponseDiscriminatorStatus.Failed,
                _ => null,
            };
        }
    }
}