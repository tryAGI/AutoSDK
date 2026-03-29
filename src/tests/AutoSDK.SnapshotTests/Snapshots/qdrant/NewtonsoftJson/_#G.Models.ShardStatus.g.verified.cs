//HintName: G.Models.ShardStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current state of the shard (supports same states as the collection)<br/>
    /// `Green` - all good. `Yellow` - optimization is running, 'Grey' - optimizations are possible but not triggered, `Red` - some operations failed and was not recovered
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShardStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="green")]
        Green,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="grey")]
        Grey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="red")]
        Red,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="yellow")]
        Yellow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShardStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShardStatus value)
        {
            return value switch
            {
                ShardStatus.Green => "green",
                ShardStatus.Grey => "grey",
                ShardStatus.Red => "red",
                ShardStatus.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShardStatus? ToEnum(string value)
        {
            return value switch
            {
                "green" => ShardStatus.Green,
                "grey" => ShardStatus.Grey,
                "red" => ShardStatus.Red,
                "yellow" => ShardStatus.Yellow,
                _ => null,
            };
        }
    }
}