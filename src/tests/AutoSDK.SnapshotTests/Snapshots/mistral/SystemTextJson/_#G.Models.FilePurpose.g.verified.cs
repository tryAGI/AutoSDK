//HintName: G.Models.FilePurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        FineTune,
        /// <summary>
        /// 
        /// </summary>
        Batch,
        /// <summary>
        /// 
        /// </summary>
        Ocr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilePurpose value)
        {
            return value switch
            {
                FilePurpose.FineTune => "fine-tune",
                FilePurpose.Batch => "batch",
                FilePurpose.Ocr => "ocr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilePurpose? ToEnum(string value)
        {
            return value switch
            {
                "fine-tune" => FilePurpose.FineTune,
                "batch" => FilePurpose.Batch,
                "ocr" => FilePurpose.Ocr,
                _ => null,
            };
        }
    }
}