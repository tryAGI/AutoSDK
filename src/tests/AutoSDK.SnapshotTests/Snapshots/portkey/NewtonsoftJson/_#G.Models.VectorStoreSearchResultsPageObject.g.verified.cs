//HintName: G.Models.VectorStoreSearchResultsPageObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `vector_store.search_results.page`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreSearchResultsPageObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vector_store.search_results.page")]
        VectorStoreSearchResultsPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreSearchResultsPageObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreSearchResultsPageObject value)
        {
            return value switch
            {
                VectorStoreSearchResultsPageObject.VectorStoreSearchResultsPage => "vector_store.search_results.page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreSearchResultsPageObject? ToEnum(string value)
        {
            return value switch
            {
                "vector_store.search_results.page" => VectorStoreSearchResultsPageObject.VectorStoreSearchResultsPage,
                _ => null,
            };
        }
    }
}