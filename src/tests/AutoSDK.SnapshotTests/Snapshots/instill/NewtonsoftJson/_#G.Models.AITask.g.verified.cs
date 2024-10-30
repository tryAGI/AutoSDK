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
    [global::System.Runtime.Serialization.DataContract]
    public enum AITask
    {
        /// <summary>
        /// Image Classification - classify images into predefined categories.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_CLASSIFICATION")]
        TASKCLASSIFICATION,
        /// <summary>
        /// Object Detection - detect and localize multiple objects in images.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_DETECTION")]
        TASKDETECTION,
        /// <summary>
        /// Keypoint Detection - detect and localize multiple keypoints of objects in images.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_KEYPOINT")]
        TASKKEYPOINT,
        /// <summary>
        /// OCR (Optical Character Recognition) - detect and recognize text in images.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_OCR")]
        TASKOCR,
        /// <summary>
        /// Instance Segmentation - detect, localize and delineate multiple objects in images.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_INSTANCE_SEGMENTATION")]
        TASKINSTANCESEGMENTATION,
        /// <summary>
        /// Semantic Segmentation - classify image pixels into predefined categories.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_SEMANTIC_SEGMENTATION")]
        TASKSEMANTICSEGMENTATION,
        /// <summary>
        /// Text to Image - generate images from input text prompts.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_TEXT_TO_IMAGE")]
        TASKTEXTTOIMAGE,
        /// <summary>
        /// Image to Image - generate an image from another image.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_IMAGE_TO_IMAGE")]
        TASKIMAGETOIMAGE,
        /// <summary>
        /// Embedding - generate an embedding (a representation as coordinates) from a multimodal input.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_EMBEDDING")]
        TASKEMBEDDING,
        /// <summary>
        /// Speech Recognition - transcribe the words in an audio input.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_SPEECH_RECOGNITION")]
        TASKSPEECHRECOGNITION,
        /// <summary>
        /// Conversational Text Generation - generate text as responses to a dialog input.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_CHAT")]
        TASKCHAT,
        /// <summary>
        /// Completion Text Generation - generate text following the input prompt.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_COMPLETION")]
        TASKCOMPLETION,
        /// <summary>
        /// Custom - custom task type for free form input/output.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TASK_CUSTOM")]
        TASKCUSTOM,
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
                AITask.TASKCLASSIFICATION => "TASK_CLASSIFICATION",
                AITask.TASKDETECTION => "TASK_DETECTION",
                AITask.TASKKEYPOINT => "TASK_KEYPOINT",
                AITask.TASKOCR => "TASK_OCR",
                AITask.TASKINSTANCESEGMENTATION => "TASK_INSTANCE_SEGMENTATION",
                AITask.TASKSEMANTICSEGMENTATION => "TASK_SEMANTIC_SEGMENTATION",
                AITask.TASKTEXTTOIMAGE => "TASK_TEXT_TO_IMAGE",
                AITask.TASKIMAGETOIMAGE => "TASK_IMAGE_TO_IMAGE",
                AITask.TASKEMBEDDING => "TASK_EMBEDDING",
                AITask.TASKSPEECHRECOGNITION => "TASK_SPEECH_RECOGNITION",
                AITask.TASKCHAT => "TASK_CHAT",
                AITask.TASKCOMPLETION => "TASK_COMPLETION",
                AITask.TASKCUSTOM => "TASK_CUSTOM",
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
                "TASK_CLASSIFICATION" => AITask.TASKCLASSIFICATION,
                "TASK_DETECTION" => AITask.TASKDETECTION,
                "TASK_KEYPOINT" => AITask.TASKKEYPOINT,
                "TASK_OCR" => AITask.TASKOCR,
                "TASK_INSTANCE_SEGMENTATION" => AITask.TASKINSTANCESEGMENTATION,
                "TASK_SEMANTIC_SEGMENTATION" => AITask.TASKSEMANTICSEGMENTATION,
                "TASK_TEXT_TO_IMAGE" => AITask.TASKTEXTTOIMAGE,
                "TASK_IMAGE_TO_IMAGE" => AITask.TASKIMAGETOIMAGE,
                "TASK_EMBEDDING" => AITask.TASKEMBEDDING,
                "TASK_SPEECH_RECOGNITION" => AITask.TASKSPEECHRECOGNITION,
                "TASK_CHAT" => AITask.TASKCHAT,
                "TASK_COMPLETION" => AITask.TASKCOMPLETION,
                "TASK_CUSTOM" => AITask.TASKCUSTOM,
                _ => null,
            };
        }
    }
}