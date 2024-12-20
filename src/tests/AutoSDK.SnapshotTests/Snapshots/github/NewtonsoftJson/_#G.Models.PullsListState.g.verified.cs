﻿//HintName: G.Models.PullsListState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullsListState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsListStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsListState value)
        {
            return value switch
            {
                PullsListState.Open => "open",
                PullsListState.Closed => "closed",
                PullsListState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsListState? ToEnum(string value)
        {
            return value switch
            {
                "open" => PullsListState.Open,
                "closed" => PullsListState.Closed,
                "all" => PullsListState.All,
                _ => null,
            };
        }
    }
}