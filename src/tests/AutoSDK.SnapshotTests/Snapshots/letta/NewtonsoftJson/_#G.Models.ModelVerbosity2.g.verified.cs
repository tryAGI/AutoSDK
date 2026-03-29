//HintName: G.Models.ModelVerbosity2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelVerbosity2
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
    public static class ModelVerbosity2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVerbosity2 value)
        {
            return value switch
            {
                ModelVerbosity2.High => "high",
                ModelVerbosity2.Low => "low",
                ModelVerbosity2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVerbosity2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelVerbosity2.High,
                "low" => ModelVerbosity2.Low,
                "medium" => ModelVerbosity2.Medium,
                _ => null,
            };
        }
    }
}