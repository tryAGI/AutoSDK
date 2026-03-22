//HintName: G.Models.UsageVectorStoresBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageVectorStoresBucketWidth
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
    public static class UsageVectorStoresBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageVectorStoresBucketWidth value)
        {
            return value switch
            {
                UsageVectorStoresBucketWidth.x1d => "1d",
                UsageVectorStoresBucketWidth.x1h => "1h",
                UsageVectorStoresBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageVectorStoresBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => UsageVectorStoresBucketWidth.x1d,
                "1h" => UsageVectorStoresBucketWidth.x1h,
                "1m" => UsageVectorStoresBucketWidth.x1m,
                _ => null,
            };
        }
    }
}