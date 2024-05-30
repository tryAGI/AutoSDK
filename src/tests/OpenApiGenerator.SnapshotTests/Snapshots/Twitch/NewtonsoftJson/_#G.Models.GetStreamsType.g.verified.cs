//HintName: G.Models.GetStreamsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetStreamsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="live")]
        Live,
    }

    public static class GetStreamsTypeExtensions
    {
        public static string ToValueString(this GetStreamsType value)
        {
            return value switch
            {
                GetStreamsType.All => "all",
                GetStreamsType.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetStreamsType ToEnum(string value)
        {
            return value switch
            {
                "all" => GetStreamsType.All,
                "live" => GetStreamsType.Live,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetStreamsType ToEnum(int value)
        {
            return value switch
            {
                0 => GetStreamsType.All,
                1 => GetStreamsType.Live,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}