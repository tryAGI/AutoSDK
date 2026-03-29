//HintName: G.Models.ExperimentItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="passed")]
        Passed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentItemStatus value)
        {
            return value switch
            {
                ExperimentItemStatus.Failed => "failed",
                ExperimentItemStatus.Passed => "passed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ExperimentItemStatus.Failed,
                "passed" => ExperimentItemStatus.Passed,
                _ => null,
            };
        }
    }
}