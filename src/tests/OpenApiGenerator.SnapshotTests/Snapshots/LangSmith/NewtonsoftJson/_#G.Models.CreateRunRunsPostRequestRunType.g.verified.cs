//HintName: G.Models.CreateRunRunsPostRequestRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRunRunsPostRequestRunType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chain")]
        Chain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retriever")]
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embedding")]
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parser")]
        Parser,
    }
}