//HintName: G.Models.OpenAIFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploaded")]
        Uploaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processed")]
        Processed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }
}