//HintName: G.Models.HFTasksE.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HFTasksE
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automatic-speech-recognition")]
        AutomaticSpeechRecognition,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image-classification")]
        ImageClassification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="question-answering")]
        QuestionAnswering,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="token-classification")]
        TokenClassification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-image")]
        TextToImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fill-mask")]
        FillMask,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zero-shot-image-classification")]
        ZeroShotImageClassification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text2text-generation")]
        Text2textGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-generation")]
        TextGeneration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-classification")]
        TextClassification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object-detection")]
        ObjectDetection,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embeddings")]
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dreambooth")]
        Dreambooth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-speech")]
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-video")]
        TextToVideo,
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
                HFTasksE.ImageClassification => "image-classification",
                HFTasksE.QuestionAnswering => "question-answering",
                HFTasksE.TokenClassification => "token-classification",
                HFTasksE.TextToImage => "text-to-image",
                HFTasksE.FillMask => "fill-mask",
                HFTasksE.ZeroShotImageClassification => "zero-shot-image-classification",
                HFTasksE.Text2textGeneration => "text2text-generation",
                HFTasksE.TextGeneration => "text-generation",
                HFTasksE.TextClassification => "text-classification",
                HFTasksE.ObjectDetection => "object-detection",
                HFTasksE.Embeddings => "embeddings",
                HFTasksE.Dreambooth => "dreambooth",
                HFTasksE.Custom => "custom",
                HFTasksE.TextToSpeech => "text-to-speech",
                HFTasksE.TextToVideo => "text-to-video",
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
                "image-classification" => HFTasksE.ImageClassification,
                "question-answering" => HFTasksE.QuestionAnswering,
                "token-classification" => HFTasksE.TokenClassification,
                "text-to-image" => HFTasksE.TextToImage,
                "fill-mask" => HFTasksE.FillMask,
                "zero-shot-image-classification" => HFTasksE.ZeroShotImageClassification,
                "text2text-generation" => HFTasksE.Text2textGeneration,
                "text-generation" => HFTasksE.TextGeneration,
                "text-classification" => HFTasksE.TextClassification,
                "object-detection" => HFTasksE.ObjectDetection,
                "embeddings" => HFTasksE.Embeddings,
                "dreambooth" => HFTasksE.Dreambooth,
                "custom" => HFTasksE.Custom,
                "text-to-speech" => HFTasksE.TextToSpeech,
                "text-to-video" => HFTasksE.TextToVideo,
                _ => null,
            };
        }
    }
}