//HintName: G.Models.DeleteVectorStoreResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteVectorStoreResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vector_store.deleted")]
        VectorStoredeleted,
    }

    public static class DeleteVectorStoreResponseObjectExtensions
    {
        public static string ToValueString(this DeleteVectorStoreResponseObject value)
        {
            return value switch
            {
                DeleteVectorStoreResponseObject.VectorStoredeleted => "vector_store.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteVectorStoreResponseObject ToEnum(string value)
        {
            return value switch
            {
                "vector_store.deleted" => DeleteVectorStoreResponseObject.VectorStoredeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteVectorStoreResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => DeleteVectorStoreResponseObject.VectorStoredeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}