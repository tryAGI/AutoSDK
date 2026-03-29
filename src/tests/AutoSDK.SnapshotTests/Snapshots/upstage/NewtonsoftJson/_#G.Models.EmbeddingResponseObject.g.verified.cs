//HintName: G.Models.EmbeddingResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, always "list".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingResponseObject value)
        {
            return value switch
            {
                EmbeddingResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => EmbeddingResponseObject.List,
                _ => null,
            };
        }
    }
}