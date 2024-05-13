//HintName: G.Models.CreateFileRequestPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file.
    /// Use "assistants" for [Assistants](/docs/api-reference/assistants) and [Message](/docs/api-reference/messages) files, "vision" for Assistants image file inputs, "batch" for [Batch API](/docs/guides/batch), and "fine-tune" for [Fine-tuning](/docs/api-reference/fine-tuning).
    /// </summary>
    public abstract class CreateFileRequestPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Assistants = "assistants";
        /// <summary>
        /// 
        /// </summary>
        public const string Batch = "batch";
        /// <summary>
        /// 
        /// </summary>
        public const string FineTune = "fine-tune";
    }
}