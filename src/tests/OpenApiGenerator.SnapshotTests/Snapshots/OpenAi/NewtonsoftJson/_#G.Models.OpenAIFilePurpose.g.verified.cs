//HintName: G.Models.OpenAIFilePurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results` and `vision`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIFilePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistants")]
        Assistants,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistants_output")]
        AssistantsOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batch")]
        Batch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batch_output")]
        BatchOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fine-tune")]
        FineTune,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fine-tune-results")]
        FineTuneResults,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vision")]
        Vision,
    }
}