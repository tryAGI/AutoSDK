//HintName: G.Models.DeleteVectorStoreResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteVectorStoreResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        VectorStoreDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteVectorStoreResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteVectorStoreResponseObject value)
        {
            return value switch
            {
                DeleteVectorStoreResponseObject.VectorStoreDeleted => "vector_store.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVectorStoreResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "vector_store.deleted" => DeleteVectorStoreResponseObject.VectorStoreDeleted,
                _ => null,
            };
        }
    }
}