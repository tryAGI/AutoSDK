//HintName: G.Models.PushModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status pushing the model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PushModelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retrieving manifest")]
        RetrievingManifest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starting upload")]
        StartingUpload,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pushing manifest")]
        PushingManifest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }
}