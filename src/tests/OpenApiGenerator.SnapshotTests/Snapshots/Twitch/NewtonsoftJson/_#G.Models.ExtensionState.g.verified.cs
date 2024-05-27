//HintName: G.Models.ExtensionState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The extension’s state. Possible values are:  
    ///   
    /// * Approved
    /// * AssetsUploaded
    /// * Deleted
    /// * Deprecated
    /// * InReview
    /// * InTest
    /// * PendingAction
    /// * Rejected
    /// * Released
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtensionState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Approved")]
        Approved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AssetsUploaded")]
        AssetsUploaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Deleted")]
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Deprecated")]
        Deprecated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="InReview")]
        InReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="InTest")]
        InTest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PendingAction")]
        PendingAction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Released")]
        Released,
    }
}