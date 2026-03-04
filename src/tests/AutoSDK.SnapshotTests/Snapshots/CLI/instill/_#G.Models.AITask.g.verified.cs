//HintName: G.Models.AITask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Task enumerates the AI task that a model is designed to solve.<br/>
    ///  - TASK_CLASSIFICATION: Image Classification - classify images into predefined categories.<br/>
    ///  - TASK_DETECTION: Object Detection - detect and localize multiple objects in images.<br/>
    ///  - TASK_KEYPOINT: Keypoint Detection - detect and localize multiple keypoints of objects in images.<br/>
    ///  - TASK_OCR: OCR (Optical Character Recognition) - detect and recognize text in images.<br/>
    ///  - TASK_INSTANCE_SEGMENTATION: Instance Segmentation - detect, localize and delineate multiple objects in images.<br/>
    ///  - TASK_SEMANTIC_SEGMENTATION: Semantic Segmentation - classify image pixels into predefined categories.<br/>
    ///  - TASK_TEXT_TO_IMAGE: Text to Image - generate images from input text prompts.<br/>
    ///  - TASK_IMAGE_TO_IMAGE: Image to Image - generate an image from another image.<br/>
    ///  - TASK_EMBEDDING: Embedding - generate an embedding (a representation as coordinates) from a multimodal input.<br/>
    ///  - TASK_SPEECH_RECOGNITION: Speech Recognition - transcribe the words in an audio input.<br/>
    ///  - TASK_CHAT: Conversational Text Generation - generate text as responses to a dialog input.<br/>
    ///  - TASK_COMPLETION: Completion Text Generation - generate text following the input prompt.<br/>
    ///  - TASK_CUSTOM: Custom - custom task type for free form input/output.
    /// </summary>
    public enum AITask
    {
        /// <summary>
        /// Image Classification - classify images into predefined categories.
        /// </summary>
        TaskClassification,
        /// <summary>
        /// Object Detection - detect and localize multiple objects in images.
        /// </summary>
        TaskDetection,
        /// <summary>
        /// Keypoint Detection - detect and localize multiple keypoints of objects in images.
        /// </summary>
        TaskKeypoint,
        /// <summary>
        /// OCR (Optical Character Recognition) - detect and recognize text in images.
        /// </summary>
        TaskOcr,
        /// <summary>
        /// Instance Segmentation - detect, localize and delineate multiple objects in images.
        /// </summary>
        TaskInstanceSegmentation,
        /// <summary>
        /// Semantic Segmentation - classify image pixels into predefined categories.
        /// </summary>
        TaskSemanticSegmentation,
        /// <summary>
        /// Text to Image - generate images from input text prompts.
        /// </summary>
        TaskTextToImage,
        /// <summary>
        /// Image to Image - generate an image from another image.
        /// </summary>
        TaskImageToImage,
        /// <summary>
        /// Embedding - generate an embedding (a representation as coordinates) from a multimodal input.
        /// </summary>
        TaskEmbedding,
        /// <summary>
        /// Speech Recognition - transcribe the words in an audio input.
        /// </summary>
        TaskSpeechRecognition,
        /// <summary>
        /// Conversational Text Generation - generate text as responses to a dialog input.
        /// </summary>
        TaskChat,
        /// <summary>
        /// Completion Text Generation - generate text following the input prompt.
        /// </summary>
        TaskCompletion,
        /// <summary>
        /// Custom - custom task type for free form input/output.
        /// </summary>
        TaskCustom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AITaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AITask value)
        {
            return value switch
            {
                AITask.TaskClassification => "TASK_CLASSIFICATION",
                AITask.TaskDetection => "TASK_DETECTION",
                AITask.TaskKeypoint => "TASK_KEYPOINT",
                AITask.TaskOcr => "TASK_OCR",
                AITask.TaskInstanceSegmentation => "TASK_INSTANCE_SEGMENTATION",
                AITask.TaskSemanticSegmentation => "TASK_SEMANTIC_SEGMENTATION",
                AITask.TaskTextToImage => "TASK_TEXT_TO_IMAGE",
                AITask.TaskImageToImage => "TASK_IMAGE_TO_IMAGE",
                AITask.TaskEmbedding => "TASK_EMBEDDING",
                AITask.TaskSpeechRecognition => "TASK_SPEECH_RECOGNITION",
                AITask.TaskChat => "TASK_CHAT",
                AITask.TaskCompletion => "TASK_COMPLETION",
                AITask.TaskCustom => "TASK_CUSTOM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AITask? ToEnum(string value)
        {
            return value switch
            {
                "TASK_CLASSIFICATION" => AITask.TaskClassification,
                "TASK_DETECTION" => AITask.TaskDetection,
                "TASK_KEYPOINT" => AITask.TaskKeypoint,
                "TASK_OCR" => AITask.TaskOcr,
                "TASK_INSTANCE_SEGMENTATION" => AITask.TaskInstanceSegmentation,
                "TASK_SEMANTIC_SEGMENTATION" => AITask.TaskSemanticSegmentation,
                "TASK_TEXT_TO_IMAGE" => AITask.TaskTextToImage,
                "TASK_IMAGE_TO_IMAGE" => AITask.TaskImageToImage,
                "TASK_EMBEDDING" => AITask.TaskEmbedding,
                "TASK_SPEECH_RECOGNITION" => AITask.TaskSpeechRecognition,
                "TASK_CHAT" => AITask.TaskChat,
                "TASK_COMPLETION" => AITask.TaskCompletion,
                "TASK_CUSTOM" => AITask.TaskCustom,
                _ => null,
            };
        }
    }
}