//HintName: G.Models.ApiJobResponsePriority.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiJobResponsePriority
    {
        /// <summary>
        /// LOW, NORMAL, HIGH
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HIGH")]
        High,
        /// <summary>
        /// LOW, NORMAL, HIGH
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOW")]
        Low,
        /// <summary>
        /// LOW, NORMAL, HIGH
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NORMAL")]
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiJobResponsePriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiJobResponsePriority value)
        {
            return value switch
            {
                ApiJobResponsePriority.High => "HIGH",
                ApiJobResponsePriority.Low => "LOW",
                ApiJobResponsePriority.Normal => "NORMAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiJobResponsePriority? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => ApiJobResponsePriority.High,
                "LOW" => ApiJobResponsePriority.Low,
                "NORMAL" => ApiJobResponsePriority.Normal,
                _ => null,
            };
        }
    }
}