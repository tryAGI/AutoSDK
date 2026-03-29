//HintName: G.Models.AllowedRequestTypesParametersBlockedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AllowedRequestTypesParametersBlockedType
    {
        /// <summary>
        /// 
        /// </summary>
        CancelBatch,
        /// <summary>
        /// 
        /// </summary>
        CancelFinetune,
        /// <summary>
        /// 
        /// </summary>
        ChatComplete,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        CreateBatch,
        /// <summary>
        /// 
        /// </summary>
        CreateFinetune,
        /// <summary>
        /// 
        /// </summary>
        CreateModelResponse,
        /// <summary>
        /// 
        /// </summary>
        CreateSpeech,
        /// <summary>
        /// 
        /// </summary>
        CreateTranscription,
        /// <summary>
        /// 
        /// </summary>
        CreateTranslation,
        /// <summary>
        /// 
        /// </summary>
        DeleteFile,
        /// <summary>
        /// 
        /// </summary>
        DeleteModelResponse,
        /// <summary>
        /// 
        /// </summary>
        Embed,
        /// <summary>
        /// 
        /// </summary>
        GetBatchOutput,
        /// <summary>
        /// 
        /// </summary>
        GetModelResponse,
        /// <summary>
        /// 
        /// </summary>
        ImageGenerate,
        /// <summary>
        /// 
        /// </summary>
        ListBatches,
        /// <summary>
        /// 
        /// </summary>
        ListFiles,
        /// <summary>
        /// 
        /// </summary>
        ListFinetunes,
        /// <summary>
        /// 
        /// </summary>
        ListResponseInputItems,
        /// <summary>
        /// 
        /// </summary>
        Messages,
        /// <summary>
        /// 
        /// </summary>
        Moderate,
        /// <summary>
        /// 
        /// </summary>
        Proxy,
        /// <summary>
        /// 
        /// </summary>
        Realtime,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        RetrieveBatch,
        /// <summary>
        /// 
        /// </summary>
        RetrieveFile,
        /// <summary>
        /// 
        /// </summary>
        RetrieveFileContent,
        /// <summary>
        /// 
        /// </summary>
        RetrieveFinetune,
        /// <summary>
        /// 
        /// </summary>
        UploadFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AllowedRequestTypesParametersBlockedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllowedRequestTypesParametersBlockedType value)
        {
            return value switch
            {
                AllowedRequestTypesParametersBlockedType.CancelBatch => "cancelBatch",
                AllowedRequestTypesParametersBlockedType.CancelFinetune => "cancelFinetune",
                AllowedRequestTypesParametersBlockedType.ChatComplete => "chatComplete",
                AllowedRequestTypesParametersBlockedType.Complete => "complete",
                AllowedRequestTypesParametersBlockedType.CreateBatch => "createBatch",
                AllowedRequestTypesParametersBlockedType.CreateFinetune => "createFinetune",
                AllowedRequestTypesParametersBlockedType.CreateModelResponse => "createModelResponse",
                AllowedRequestTypesParametersBlockedType.CreateSpeech => "createSpeech",
                AllowedRequestTypesParametersBlockedType.CreateTranscription => "createTranscription",
                AllowedRequestTypesParametersBlockedType.CreateTranslation => "createTranslation",
                AllowedRequestTypesParametersBlockedType.DeleteFile => "deleteFile",
                AllowedRequestTypesParametersBlockedType.DeleteModelResponse => "deleteModelResponse",
                AllowedRequestTypesParametersBlockedType.Embed => "embed",
                AllowedRequestTypesParametersBlockedType.GetBatchOutput => "getBatchOutput",
                AllowedRequestTypesParametersBlockedType.GetModelResponse => "getModelResponse",
                AllowedRequestTypesParametersBlockedType.ImageGenerate => "imageGenerate",
                AllowedRequestTypesParametersBlockedType.ListBatches => "listBatches",
                AllowedRequestTypesParametersBlockedType.ListFiles => "listFiles",
                AllowedRequestTypesParametersBlockedType.ListFinetunes => "listFinetunes",
                AllowedRequestTypesParametersBlockedType.ListResponseInputItems => "listResponseInputItems",
                AllowedRequestTypesParametersBlockedType.Messages => "messages",
                AllowedRequestTypesParametersBlockedType.Moderate => "moderate",
                AllowedRequestTypesParametersBlockedType.Proxy => "proxy",
                AllowedRequestTypesParametersBlockedType.Realtime => "realtime",
                AllowedRequestTypesParametersBlockedType.Rerank => "rerank",
                AllowedRequestTypesParametersBlockedType.RetrieveBatch => "retrieveBatch",
                AllowedRequestTypesParametersBlockedType.RetrieveFile => "retrieveFile",
                AllowedRequestTypesParametersBlockedType.RetrieveFileContent => "retrieveFileContent",
                AllowedRequestTypesParametersBlockedType.RetrieveFinetune => "retrieveFinetune",
                AllowedRequestTypesParametersBlockedType.UploadFile => "uploadFile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllowedRequestTypesParametersBlockedType? ToEnum(string value)
        {
            return value switch
            {
                "cancelBatch" => AllowedRequestTypesParametersBlockedType.CancelBatch,
                "cancelFinetune" => AllowedRequestTypesParametersBlockedType.CancelFinetune,
                "chatComplete" => AllowedRequestTypesParametersBlockedType.ChatComplete,
                "complete" => AllowedRequestTypesParametersBlockedType.Complete,
                "createBatch" => AllowedRequestTypesParametersBlockedType.CreateBatch,
                "createFinetune" => AllowedRequestTypesParametersBlockedType.CreateFinetune,
                "createModelResponse" => AllowedRequestTypesParametersBlockedType.CreateModelResponse,
                "createSpeech" => AllowedRequestTypesParametersBlockedType.CreateSpeech,
                "createTranscription" => AllowedRequestTypesParametersBlockedType.CreateTranscription,
                "createTranslation" => AllowedRequestTypesParametersBlockedType.CreateTranslation,
                "deleteFile" => AllowedRequestTypesParametersBlockedType.DeleteFile,
                "deleteModelResponse" => AllowedRequestTypesParametersBlockedType.DeleteModelResponse,
                "embed" => AllowedRequestTypesParametersBlockedType.Embed,
                "getBatchOutput" => AllowedRequestTypesParametersBlockedType.GetBatchOutput,
                "getModelResponse" => AllowedRequestTypesParametersBlockedType.GetModelResponse,
                "imageGenerate" => AllowedRequestTypesParametersBlockedType.ImageGenerate,
                "listBatches" => AllowedRequestTypesParametersBlockedType.ListBatches,
                "listFiles" => AllowedRequestTypesParametersBlockedType.ListFiles,
                "listFinetunes" => AllowedRequestTypesParametersBlockedType.ListFinetunes,
                "listResponseInputItems" => AllowedRequestTypesParametersBlockedType.ListResponseInputItems,
                "messages" => AllowedRequestTypesParametersBlockedType.Messages,
                "moderate" => AllowedRequestTypesParametersBlockedType.Moderate,
                "proxy" => AllowedRequestTypesParametersBlockedType.Proxy,
                "realtime" => AllowedRequestTypesParametersBlockedType.Realtime,
                "rerank" => AllowedRequestTypesParametersBlockedType.Rerank,
                "retrieveBatch" => AllowedRequestTypesParametersBlockedType.RetrieveBatch,
                "retrieveFile" => AllowedRequestTypesParametersBlockedType.RetrieveFile,
                "retrieveFileContent" => AllowedRequestTypesParametersBlockedType.RetrieveFileContent,
                "retrieveFinetune" => AllowedRequestTypesParametersBlockedType.RetrieveFinetune,
                "uploadFile" => AllowedRequestTypesParametersBlockedType.UploadFile,
                _ => null,
            };
        }
    }
}