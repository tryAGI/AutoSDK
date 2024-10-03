//HintName: G.Models.UploadFileOutPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file. Only accepts fine-tuning (`fine-tune`) for now.
    /// </summary>
    public enum UploadFileOutPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        FineTune,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadFileOutPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadFileOutPurpose value)
        {
            return value switch
            {
                UploadFileOutPurpose.FineTune => "fine-tune",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadFileOutPurpose? ToEnum(string value)
        {
            return value switch
            {
                "fine-tune" => UploadFileOutPurpose.FineTune,
                _ => null,
            };
        }
    }
}