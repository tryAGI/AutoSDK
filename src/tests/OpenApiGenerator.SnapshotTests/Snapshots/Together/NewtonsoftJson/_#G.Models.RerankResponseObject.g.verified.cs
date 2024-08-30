//HintName: G.Models.RerankResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object type<br/>
    /// Example: rerank
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RerankResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rerank")]
        Rerank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerankResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerankResponseObject value)
        {
            return value switch
            {
                RerankResponseObject.Rerank => "rerank",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerankResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "rerank" => RerankResponseObject.Rerank,
                _ => null,
            };
        }
    }
}