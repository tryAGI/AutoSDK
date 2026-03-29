//HintName: G.Models.AllowedRequestTypesParametersAllowedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AllowedRequestTypesParametersAllowedType
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
    public static class AllowedRequestTypesParametersAllowedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllowedRequestTypesParametersAllowedType value)
        {
            return value switch
            {
                AllowedRequestTypesParametersAllowedType.CancelBatch => "cancelBatch",
                AllowedRequestTypesParametersAllowedType.CancelFinetune => "cancelFinetune",
                AllowedRequestTypesParametersAllowedType.ChatComplete => "chatComplete",
                AllowedRequestTypesParametersAllowedType.Complete => "complete",
                AllowedRequestTypesParametersAllowedType.CreateBatch => "createBatch",
                AllowedRequestTypesParametersAllowedType.CreateFinetune => "createFinetune",
                AllowedRequestTypesParametersAllowedType.CreateModelResponse => "createModelResponse",
                AllowedRequestTypesParametersAllowedType.CreateSpeech => "createSpeech",
                AllowedRequestTypesParametersAllowedType.CreateTranscription => "createTranscription",
                AllowedRequestTypesParametersAllowedType.CreateTranslation => "createTranslation",
                AllowedRequestTypesParametersAllowedType.DeleteFile => "deleteFile",
                AllowedRequestTypesParametersAllowedType.DeleteModelResponse => "deleteModelResponse",
                AllowedRequestTypesParametersAllowedType.Embed => "embed",
                AllowedRequestTypesParametersAllowedType.GetBatchOutput => "getBatchOutput",
                AllowedRequestTypesParametersAllowedType.GetModelResponse => "getModelResponse",
                AllowedRequestTypesParametersAllowedType.ImageGenerate => "imageGenerate",
                AllowedRequestTypesParametersAllowedType.ListBatches => "listBatches",
                AllowedRequestTypesParametersAllowedType.ListFiles => "listFiles",
                AllowedRequestTypesParametersAllowedType.ListFinetunes => "listFinetunes",
                AllowedRequestTypesParametersAllowedType.ListResponseInputItems => "listResponseInputItems",
                AllowedRequestTypesParametersAllowedType.Messages => "messages",
                AllowedRequestTypesParametersAllowedType.Moderate => "moderate",
                AllowedRequestTypesParametersAllowedType.Proxy => "proxy",
                AllowedRequestTypesParametersAllowedType.Realtime => "realtime",
                AllowedRequestTypesParametersAllowedType.Rerank => "rerank",
                AllowedRequestTypesParametersAllowedType.RetrieveBatch => "retrieveBatch",
                AllowedRequestTypesParametersAllowedType.RetrieveFile => "retrieveFile",
                AllowedRequestTypesParametersAllowedType.RetrieveFileContent => "retrieveFileContent",
                AllowedRequestTypesParametersAllowedType.RetrieveFinetune => "retrieveFinetune",
                AllowedRequestTypesParametersAllowedType.UploadFile => "uploadFile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllowedRequestTypesParametersAllowedType? ToEnum(string value)
        {
            return value switch
            {
                "cancelBatch" => AllowedRequestTypesParametersAllowedType.CancelBatch,
                "cancelFinetune" => AllowedRequestTypesParametersAllowedType.CancelFinetune,
                "chatComplete" => AllowedRequestTypesParametersAllowedType.ChatComplete,
                "complete" => AllowedRequestTypesParametersAllowedType.Complete,
                "createBatch" => AllowedRequestTypesParametersAllowedType.CreateBatch,
                "createFinetune" => AllowedRequestTypesParametersAllowedType.CreateFinetune,
                "createModelResponse" => AllowedRequestTypesParametersAllowedType.CreateModelResponse,
                "createSpeech" => AllowedRequestTypesParametersAllowedType.CreateSpeech,
                "createTranscription" => AllowedRequestTypesParametersAllowedType.CreateTranscription,
                "createTranslation" => AllowedRequestTypesParametersAllowedType.CreateTranslation,
                "deleteFile" => AllowedRequestTypesParametersAllowedType.DeleteFile,
                "deleteModelResponse" => AllowedRequestTypesParametersAllowedType.DeleteModelResponse,
                "embed" => AllowedRequestTypesParametersAllowedType.Embed,
                "getBatchOutput" => AllowedRequestTypesParametersAllowedType.GetBatchOutput,
                "getModelResponse" => AllowedRequestTypesParametersAllowedType.GetModelResponse,
                "imageGenerate" => AllowedRequestTypesParametersAllowedType.ImageGenerate,
                "listBatches" => AllowedRequestTypesParametersAllowedType.ListBatches,
                "listFiles" => AllowedRequestTypesParametersAllowedType.ListFiles,
                "listFinetunes" => AllowedRequestTypesParametersAllowedType.ListFinetunes,
                "listResponseInputItems" => AllowedRequestTypesParametersAllowedType.ListResponseInputItems,
                "messages" => AllowedRequestTypesParametersAllowedType.Messages,
                "moderate" => AllowedRequestTypesParametersAllowedType.Moderate,
                "proxy" => AllowedRequestTypesParametersAllowedType.Proxy,
                "realtime" => AllowedRequestTypesParametersAllowedType.Realtime,
                "rerank" => AllowedRequestTypesParametersAllowedType.Rerank,
                "retrieveBatch" => AllowedRequestTypesParametersAllowedType.RetrieveBatch,
                "retrieveFile" => AllowedRequestTypesParametersAllowedType.RetrieveFile,
                "retrieveFileContent" => AllowedRequestTypesParametersAllowedType.RetrieveFileContent,
                "retrieveFinetune" => AllowedRequestTypesParametersAllowedType.RetrieveFinetune,
                "uploadFile" => AllowedRequestTypesParametersAllowedType.UploadFile,
                _ => null,
            };
        }
    }
}