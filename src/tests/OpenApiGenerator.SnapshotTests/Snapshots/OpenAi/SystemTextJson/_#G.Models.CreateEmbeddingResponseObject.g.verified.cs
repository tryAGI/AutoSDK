//HintName: G.Models.CreateEmbeddingResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "list".
    /// </summary>
    public enum CreateEmbeddingResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    public static class CreateEmbeddingResponseObjectExtensions
    {
        public static string ToValueString(this CreateEmbeddingResponseObject value)
        {
            return value switch
            {
                CreateEmbeddingResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateEmbeddingResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => CreateEmbeddingResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateEmbeddingResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => CreateEmbeddingResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}