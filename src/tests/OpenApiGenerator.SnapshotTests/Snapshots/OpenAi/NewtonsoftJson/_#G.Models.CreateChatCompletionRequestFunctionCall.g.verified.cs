//HintName: G.Models.CreateChatCompletionRequestFunctionCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call a function and instead generates a message. `auto` means the model can pick between generating a message or calling a function.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestFunctionCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }
}