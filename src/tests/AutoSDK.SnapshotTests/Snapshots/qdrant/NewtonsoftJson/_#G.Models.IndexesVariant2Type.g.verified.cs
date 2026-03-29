//HintName: G.Models.IndexesVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IndexesVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hnsw")]
        Hnsw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexesVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexesVariant2Type value)
        {
            return value switch
            {
                IndexesVariant2Type.Hnsw => "hnsw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexesVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "hnsw" => IndexesVariant2Type.Hnsw,
                _ => null,
            };
        }
    }
}