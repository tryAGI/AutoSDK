//HintName: G.Models.ExtensionSubscriptionsSupportLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates whether the extension can view the user’s subscription level on the channel that the extension is installed on. Possible values are:  
    ///   
    /// * none — The extension can't view the user’s subscription level.
    /// * optional — The extension can view the user’s subscription level.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtensionSubscriptionsSupportLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="optional")]
        Optional,
    }
}