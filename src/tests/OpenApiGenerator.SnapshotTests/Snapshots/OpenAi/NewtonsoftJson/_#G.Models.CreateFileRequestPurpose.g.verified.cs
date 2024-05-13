//HintName: G.Models.CreateFileRequestPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file.
    /// Use "assistants" for [Assistants](/docs/api-reference/assistants) and [Message](/docs/api-reference/messages) files, "vision" for Assistants image file inputs, "batch" for [Batch API](/docs/guides/batch), and "fine-tune" for [Fine-tuning](/docs/api-reference/fine-tuning).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateFileRequestPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistants")]
        Assistants,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batch")]
        Batch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fine-tune")]
        FineTune,
    }
}