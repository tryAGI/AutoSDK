//HintName: G.Models.CreateModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status creating the model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="creating system layer")]
        CreatingSystemLayer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parsing modelfile")]
        ParsingModelfile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }
}