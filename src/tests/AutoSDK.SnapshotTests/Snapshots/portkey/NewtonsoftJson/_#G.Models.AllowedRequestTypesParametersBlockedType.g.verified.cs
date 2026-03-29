//HintName: G.Models.AllowedRequestTypesParametersBlockedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AllowedRequestTypesParametersBlockedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelBatch")]
        CancelBatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelFinetune")]
        CancelFinetune,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chatComplete")]
        ChatComplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="createBatch")]
        CreateBatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="createFinetune")]
        CreateFinetune,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="createModelResponse")]
        CreateModelResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="createSpeech")]
        CreateSpeech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="createTranscription")]
        CreateTranscription,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="createTranslation")]
        CreateTranslation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleteFile")]
        DeleteFile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleteModelResponse")]
        DeleteModelResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embed")]
        Embed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="getBatchOutput")]
        GetBatchOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="getModelResponse")]
        GetModelResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="imageGenerate")]
        ImageGenerate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="listBatches")]
        ListBatches,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="listFiles")]
        ListFiles,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="listFinetunes")]
        ListFinetunes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="listResponseInputItems")]
        ListResponseInputItems,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="messages")]
        Messages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moderate")]
        Moderate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="proxy")]
        Proxy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="realtime")]
        Realtime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rerank")]
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retrieveBatch")]
        RetrieveBatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retrieveFile")]
        RetrieveFile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retrieveFileContent")]
        RetrieveFileContent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retrieveFinetune")]
        RetrieveFinetune,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploadFile")]
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