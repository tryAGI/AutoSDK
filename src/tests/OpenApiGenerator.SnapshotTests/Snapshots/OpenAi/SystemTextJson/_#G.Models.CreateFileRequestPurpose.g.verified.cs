//HintName: G.Models.CreateFileRequestPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file.
    /// Use "fine-tune" for [Fine-tuning](/docs/api-reference/fine-tuning) and "assistants" for [Assistants](/docs/api-reference/assistants) and [Messages](/docs/api-reference/messages). This allows us to validate the format of the uploaded file is correct for fine-tuning.
    /// </summary>
    public abstract class CreateFileRequestPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        public const string FineTune = "fine-tune";
        /// <summary>
        /// 
        /// </summary>
        public const string Assistants = "assistants";
    }
}