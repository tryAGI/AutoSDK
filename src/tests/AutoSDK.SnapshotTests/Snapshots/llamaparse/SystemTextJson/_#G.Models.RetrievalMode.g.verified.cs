//HintName: G.Models.RetrievalMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RetrievalMode
    {
        /// <summary>
        /// 
        /// </summary>
        AutoRouted,
        /// <summary>
        /// 
        /// </summary>
        Chunks,
        /// <summary>
        /// 
        /// </summary>
        FilesViaContent,
        /// <summary>
        /// 
        /// </summary>
        FilesViaMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetrievalModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievalMode value)
        {
            return value switch
            {
                RetrievalMode.AutoRouted => "auto_routed",
                RetrievalMode.Chunks => "chunks",
                RetrievalMode.FilesViaContent => "files_via_content",
                RetrievalMode.FilesViaMetadata => "files_via_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievalMode? ToEnum(string value)
        {
            return value switch
            {
                "auto_routed" => RetrievalMode.AutoRouted,
                "chunks" => RetrievalMode.Chunks,
                "files_via_content" => RetrievalMode.FilesViaContent,
                "files_via_metadata" => RetrievalMode.FilesViaMetadata,
                _ => null,
            };
        }
    }
}