//HintName: G.Models.OpenAIFilePurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the file. Supported values are `fine-tune`, `fine-tune-results`, `assistants`, and `assistants_output`.
    /// </summary>
    public abstract class OpenAIFilePurpose
    {
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
        public const string Assistants = "assistants";
        /// <summary>
        /// 
        /// </summary>
        public const string AssistantsOutput = "assistants_output";
    }
}