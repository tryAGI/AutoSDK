//HintName: G.Models.ReadLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReadLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="index_and_wal")]
        IndexAndWal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="index_only")]
        IndexOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadLevel value)
        {
            return value switch
            {
                ReadLevel.IndexAndWal => "index_and_wal",
                ReadLevel.IndexOnly => "index_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadLevel? ToEnum(string value)
        {
            return value switch
            {
                "index_and_wal" => ReadLevel.IndexAndWal,
                "index_only" => ReadLevel.IndexOnly,
                _ => null,
            };
        }
    }
}