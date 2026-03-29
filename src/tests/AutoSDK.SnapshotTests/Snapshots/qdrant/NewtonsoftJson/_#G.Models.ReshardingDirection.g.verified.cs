//HintName: G.Models.ReshardingDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Resharding direction, scale up or down in number of shards<br/>
    /// - `up` - Scale up, add a new shard<br/>
    /// - `down` - Scale down, remove a shard
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReshardingDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="down")]
        Down,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="up")]
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReshardingDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReshardingDirection value)
        {
            return value switch
            {
                ReshardingDirection.Down => "down",
                ReshardingDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReshardingDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => ReshardingDirection.Down,
                "up" => ReshardingDirection.Up,
                _ => null,
            };
        }
    }
}