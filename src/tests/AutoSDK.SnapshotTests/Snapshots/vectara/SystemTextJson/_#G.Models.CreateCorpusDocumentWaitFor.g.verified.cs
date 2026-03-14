//HintName: G.Models.CreateCorpusDocumentWaitFor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: searchable
    /// </summary>
    public enum CreateCorpusDocumentWaitFor
    {
        /// <summary>
        /// Waits until the document is fully indexed and immediately searchable. Use this when you need to query the document immediately after indexing.
        /// </summary>
        Searchable,
        /// <summary>
        /// Waits until the document is fully indexed and immediately searchable. Use this when you need to query the document immediately after indexing.
        /// </summary>
        Indexed,
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
                CreateCorpusDocumentWaitFor.Searchable => "searchable",
                CreateCorpusDocumentWaitFor.Indexed => "indexed",
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
                "searchable" => CreateCorpusDocumentWaitFor.Searchable,
                "indexed" => CreateCorpusDocumentWaitFor.Indexed,
                _ => null,
            };
        }
    }
}