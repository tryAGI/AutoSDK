//HintName: G.Models.OpenAIFilePurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results` and `vision`.
    /// </summary>
    public enum OpenAIFilePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        Assistants,
        /// <summary>
        /// 
        /// </summary>
        AssistantsOutput,
        /// <summary>
        /// 
        /// </summary>
        Batch,
        /// <summary>
        /// 
        /// </summary>
        BatchOutput,
        /// <summary>
        /// 
        /// </summary>
        FineTune,
        /// <summary>
        /// 
        /// </summary>
        FineTuneResults,
        /// <summary>
        /// 
        /// </summary>
        Vision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFilePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFilePurpose value)
        {
            return value switch
            {
                OpenAIFilePurpose.Assistants => "assistants",
                OpenAIFilePurpose.AssistantsOutput => "assistants_output",
                OpenAIFilePurpose.Batch => "batch",
                OpenAIFilePurpose.BatchOutput => "batch_output",
                OpenAIFilePurpose.FineTune => "fine-tune",
                OpenAIFilePurpose.FineTuneResults => "fine-tune-results",
                OpenAIFilePurpose.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFilePurpose ToEnum(string value)
        {
            return value switch
            {
                "assistants" => OpenAIFilePurpose.Assistants,
                "assistants_output" => OpenAIFilePurpose.AssistantsOutput,
                "batch" => OpenAIFilePurpose.Batch,
                "batch_output" => OpenAIFilePurpose.BatchOutput,
                "fine-tune" => OpenAIFilePurpose.FineTune,
                "fine-tune-results" => OpenAIFilePurpose.FineTuneResults,
                "vision" => OpenAIFilePurpose.Vision,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}