//HintName: G.Models.ReadConsistencyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
    /// * `quorum` - send requests to all nodes and return points which present on majority of nodes<br/>
    /// * `all` - send requests to all nodes and return points which present on all nodes
    /// </summary>
    public enum ReadConsistencyType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Majority,
        /// <summary>
        /// 
        /// </summary>
        Quorum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadConsistencyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadConsistencyType value)
        {
            return value switch
            {
                ReadConsistencyType.All => "all",
                ReadConsistencyType.Majority => "majority",
                ReadConsistencyType.Quorum => "quorum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadConsistencyType? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReadConsistencyType.All,
                "majority" => ReadConsistencyType.Majority,
                "quorum" => ReadConsistencyType.Quorum,
                _ => null,
            };
        }
    }
}