//HintName: G.Models.OpenAIFilePurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results` and `vision`.
    /// </summary>
    public abstract class OpenAIFilePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Assistants = "assistants";
        /// <summary>
        /// 
        /// </summary>
        public const string AssistantsOutput = "assistants_output";
        /// <summary>
        /// 
        /// </summary>
        public const string Batch = "batch";
        /// <summary>
        /// 
        /// </summary>
        public const string BatchOutput = "batch_output";
        /// <summary>
        /// 
        /// </summary>
        public const string FineTune = "fine-tune";
        /// <summary>
        /// 
        /// </summary>
        public const string FineTuneResults = "fine-tune-results";
        /// <summary>
        /// 
        /// </summary>
        public const string Vision = "vision";
    }
}