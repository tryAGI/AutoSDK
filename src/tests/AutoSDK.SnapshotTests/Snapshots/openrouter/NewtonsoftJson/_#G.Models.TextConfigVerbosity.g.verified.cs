//HintName: G.Models.TextConfigVerbosity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextConfigVerbosity
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
    public static class TextConfigVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextConfigVerbosity value)
        {
            return value switch
            {
                TextConfigVerbosity.High => "high",
                TextConfigVerbosity.Low => "low",
                TextConfigVerbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextConfigVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => TextConfigVerbosity.High,
                "low" => TextConfigVerbosity.Low,
                "medium" => TextConfigVerbosity.Medium,
                _ => null,
            };
        }
    }
}