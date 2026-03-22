//HintName: G.Models.HFTasksE.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HFTasksE
    {
        /// <summary>
        /// 
        /// </summary>
        AutomaticSpeechRecognition,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Dreambooth,
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        FillMask,
        /// <summary>
        /// 
        /// </summary>
        ImageClassification,
        /// <summary>
        /// 
        /// </summary>
        ObjectDetection,
        /// <summary>
        /// 
        /// </summary>
        QuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        TextClassification,
        /// <summary>
        /// 
        /// </summary>
        TextGeneration,
        /// <summary>
        /// 
        /// </summary>
        TextToImage,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        TextToVideo,
        /// <summary>
        /// 
        /// </summary>
        Text2textGeneration,
        /// <summary>
        /// 
        /// </summary>
        TokenClassification,
        /// <summary>
        /// 
        /// </summary>
        ZeroShotImageClassification,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HFTasksEExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HFTasksE value)
        {
            return value switch
            {
                HFTasksE.AutomaticSpeechRecognition => "automatic-speech-recognition",
                HFTasksE.Custom => "custom",
                HFTasksE.Dreambooth => "dreambooth",
                HFTasksE.Embeddings => "embeddings",
                HFTasksE.FillMask => "fill-mask",
                HFTasksE.ImageClassification => "image-classification",
                HFTasksE.ObjectDetection => "object-detection",
                HFTasksE.QuestionAnswering => "question-answering",
                HFTasksE.TextClassification => "text-classification",
                HFTasksE.TextGeneration => "text-generation",
                HFTasksE.TextToImage => "text-to-image",
                HFTasksE.TextToSpeech => "text-to-speech",
                HFTasksE.TextToVideo => "text-to-video",
                HFTasksE.Text2textGeneration => "text2text-generation",
                HFTasksE.TokenClassification => "token-classification",
                HFTasksE.ZeroShotImageClassification => "zero-shot-image-classification",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HFTasksE? ToEnum(string value)
        {
            return value switch
            {
                "automatic-speech-recognition" => HFTasksE.AutomaticSpeechRecognition,
                "custom" => HFTasksE.Custom,
                "dreambooth" => HFTasksE.Dreambooth,
                "embeddings" => HFTasksE.Embeddings,
                "fill-mask" => HFTasksE.FillMask,
                "image-classification" => HFTasksE.ImageClassification,
                "object-detection" => HFTasksE.ObjectDetection,
                "question-answering" => HFTasksE.QuestionAnswering,
                "text-classification" => HFTasksE.TextClassification,
                "text-generation" => HFTasksE.TextGeneration,
                "text-to-image" => HFTasksE.TextToImage,
                "text-to-speech" => HFTasksE.TextToSpeech,
                "text-to-video" => HFTasksE.TextToVideo,
                "text2text-generation" => HFTasksE.Text2textGeneration,
                "token-classification" => HFTasksE.TokenClassification,
                "zero-shot-image-classification" => HFTasksE.ZeroShotImageClassification,
                _ => null,
            };
        }
    }
}