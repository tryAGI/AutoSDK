//HintName: G.Models.CreateFileRequestPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file.<br/>
    /// Use "assistants" for [Assistants](/docs/api-reference/assistants) and [Message](/docs/api-reference/messages) files, "vision" for Assistants image file inputs, "batch" for [Batch API](/docs/guides/batch), and "fine-tune" for [Fine-tuning](/docs/api-reference/fine-tuning).
    /// </summary>
    public enum CreateFileRequestPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        Assistants,
        /// <summary>
        /// 
        /// </summary>
        Batch,
        /// <summary>
        /// 
        /// </summary>
        FineTune,
        /// <summary>
        /// 
        /// </summary>
        Vision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFileRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFileRequestPurpose value)
        {
            return value switch
            {
                CreateFileRequestPurpose.Assistants => "assistants",
                CreateFileRequestPurpose.Batch => "batch",
                CreateFileRequestPurpose.FineTune => "fine-tune",
                CreateFileRequestPurpose.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFileRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "assistants" => CreateFileRequestPurpose.Assistants,
                "batch" => CreateFileRequestPurpose.Batch,
                "fine-tune" => CreateFileRequestPurpose.FineTune,
                "vision" => CreateFileRequestPurpose.Vision,
                _ => null,
            };
        }
    }
}