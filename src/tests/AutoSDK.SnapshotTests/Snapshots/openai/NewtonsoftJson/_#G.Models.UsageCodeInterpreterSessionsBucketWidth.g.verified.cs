//HintName: G.Models.UsageCodeInterpreterSessionsBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageCodeInterpreterSessionsBucketWidth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1d")]
        x1d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1h")]
        x1h,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1m")]
        x1m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageCodeInterpreterSessionsBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCodeInterpreterSessionsBucketWidth value)
        {
            return value switch
            {
                UsageCodeInterpreterSessionsBucketWidth.x1d => "1d",
                UsageCodeInterpreterSessionsBucketWidth.x1h => "1h",
                UsageCodeInterpreterSessionsBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCodeInterpreterSessionsBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => UsageCodeInterpreterSessionsBucketWidth.x1d,
                "1h" => UsageCodeInterpreterSessionsBucketWidth.x1h,
                "1m" => UsageCodeInterpreterSessionsBucketWidth.x1m,
                _ => null,
            };
        }
    }
}