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
                DeleteVectorStoreResponseObject.VectorStoredeleted => "vector_store.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVectorStoreResponseObject ToEnum(string value)
        {
            return value switch
            {
                "vector_store.deleted" => DeleteVectorStoreResponseObject.VectorStoredeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}