//HintName: G.Models.DeleteVectorStoreFileResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteVectorStoreFileResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        VectorStorefiledeleted,
    }

    public static class DeleteVectorStoreFileResponseObjectExtensions
    {
        public static string ToValueString(this DeleteVectorStoreFileResponseObject value)
        {
            return value switch
            {
                DeleteVectorStoreFileResponseObject.VectorStorefiledeleted => "vector_store.file.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteVectorStoreFileResponseObject ToEnum(string value)
        {
            return value switch
            {
                "vector_store.file.deleted" => DeleteVectorStoreFileResponseObject.VectorStorefiledeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteVectorStoreFileResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => DeleteVectorStoreFileResponseObject.VectorStorefiledeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}