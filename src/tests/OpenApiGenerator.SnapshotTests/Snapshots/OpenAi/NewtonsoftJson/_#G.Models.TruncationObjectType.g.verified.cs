//HintName: G.Models.TruncationObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The truncation strategy to use for the thread. The default is `auto`. If set to `last_messages`, the thread will be truncated to the n most recent messages in the thread. When set to `auto`, messages in the middle of the thread will be dropped to fit the context length of the model, `max_prompt_tokens`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TruncationObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last_messages")]
        LastMessages,
    }
}