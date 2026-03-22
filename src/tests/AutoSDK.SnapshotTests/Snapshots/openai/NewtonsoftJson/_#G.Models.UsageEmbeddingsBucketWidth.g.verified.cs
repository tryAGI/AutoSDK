//HintName: G.Models.UsageEmbeddingsBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageEmbeddingsBucketWidth
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
    public static class UsageEmbeddingsBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageEmbeddingsBucketWidth value)
        {
            return value switch
            {
                UsageEmbeddingsBucketWidth.x1d => "1d",
                UsageEmbeddingsBucketWidth.x1h => "1h",
                UsageEmbeddingsBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageEmbeddingsBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => UsageEmbeddingsBucketWidth.x1d,
                "1h" => UsageEmbeddingsBucketWidth.x1h,
                "1m" => UsageEmbeddingsBucketWidth.x1m,
                _ => null,
            };
        }
    }
}