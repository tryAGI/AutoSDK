//HintName: G.Models.CreateCorpusDocumentWaitFor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: searchable
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCorpusDocumentWaitFor
    {
        /// <summary>
        /// Waits until the document is fully indexed and immediately searchable. Use this when you need to query the document immediately after indexing.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="indexed")]
        Indexed,
        /// <summary>
        /// Waits until the document is fully indexed and immediately searchable. Use this when you need to query the document immediately after indexing.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="searchable")]
        Searchable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCorpusDocumentWaitForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCorpusDocumentWaitFor value)
        {
            return value switch
            {
                CreateCorpusDocumentWaitFor.Indexed => "indexed",
                CreateCorpusDocumentWaitFor.Searchable => "searchable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCorpusDocumentWaitFor? ToEnum(string value)
        {
            return value switch
            {
                "indexed" => CreateCorpusDocumentWaitFor.Indexed,
                "searchable" => CreateCorpusDocumentWaitFor.Searchable,
                _ => null,
            };
        }
    }
}