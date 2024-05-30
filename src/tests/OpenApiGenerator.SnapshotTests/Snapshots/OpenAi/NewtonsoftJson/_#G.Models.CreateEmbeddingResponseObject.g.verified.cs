//HintName: G.Models.CreateEmbeddingResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "list".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEmbeddingResponseObject
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
    public static class CreateEmbeddingResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingResponseObject value)
        {
            return value switch
            {
                CreateEmbeddingResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => CreateEmbeddingResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}