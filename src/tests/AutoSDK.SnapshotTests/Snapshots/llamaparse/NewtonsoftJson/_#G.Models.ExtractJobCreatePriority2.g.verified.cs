//HintName: G.Models.ExtractJobCreatePriority2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractJobCreatePriority2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="critical")]
        Critical,
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
    public static class ExtractJobCreatePriority2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractJobCreatePriority2 value)
        {
            return value switch
            {
                ExtractJobCreatePriority2.Critical => "critical",
                ExtractJobCreatePriority2.High => "high",
                ExtractJobCreatePriority2.Low => "low",
                ExtractJobCreatePriority2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractJobCreatePriority2? ToEnum(string value)
        {
            return value switch
            {
                "critical" => ExtractJobCreatePriority2.Critical,
                "high" => ExtractJobCreatePriority2.High,
                "low" => ExtractJobCreatePriority2.Low,
                "medium" => ExtractJobCreatePriority2.Medium,
                _ => null,
            };
        }
    }
}