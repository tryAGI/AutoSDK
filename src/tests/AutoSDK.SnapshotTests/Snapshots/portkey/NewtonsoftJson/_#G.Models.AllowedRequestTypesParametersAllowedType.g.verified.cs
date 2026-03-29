//HintName: G.Models.AllowedRequestTypesParametersAllowedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AllowedRequestTypesParametersAllowedType
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