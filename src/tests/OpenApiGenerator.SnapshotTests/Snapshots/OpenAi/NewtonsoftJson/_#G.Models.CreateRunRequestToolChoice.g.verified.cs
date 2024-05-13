//HintName: G.Models.CreateRunRequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRunRequestToolChoice
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required")]
        Required,
    }
}