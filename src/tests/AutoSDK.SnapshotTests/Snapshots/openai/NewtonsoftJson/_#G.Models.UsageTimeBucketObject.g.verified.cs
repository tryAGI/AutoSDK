//HintName: G.Models.UsageTimeBucketObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageTimeBucketObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bucket")]
        Bucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageTimeBucketObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageTimeBucketObject value)
        {
            return value switch
            {
                UsageTimeBucketObject.Bucket => "bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageTimeBucketObject? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => UsageTimeBucketObject.Bucket,
                _ => null,
            };
        }
    }
}