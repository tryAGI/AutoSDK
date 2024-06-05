//HintName: G.Models.DeleteVectorStoreFileResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteVectorStoreFileResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vector_store.file.deleted")]
        VectorStorefiledeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteVectorStoreFileResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteVectorStoreFileResponseObject value)
        {
            return value switch
            {
                DeleteVectorStoreFileResponseObject.VectorStorefiledeleted => "vector_store.file.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteVectorStoreFileResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "vector_store.file.deleted" => DeleteVectorStoreFileResponseObject.VectorStorefiledeleted,
                _ => null,
            };
        }
    }
}