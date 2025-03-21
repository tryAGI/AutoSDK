//HintName: G.Models.VectorStoreFileContentResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `vector_store.file_content.page`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreFileContentResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vector_store.file_content.page")]
        VectorStoreFileContentPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileContentResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileContentResponseObject value)
        {
            return value switch
            {
                VectorStoreFileContentResponseObject.VectorStoreFileContentPage => "vector_store.file_content.page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileContentResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "vector_store.file_content.page" => VectorStoreFileContentResponseObject.VectorStoreFileContentPage,
                _ => null,
            };
        }
    }
}