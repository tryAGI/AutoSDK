//HintName: G.Models.ExtensionConfigurationLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The location of where the extension’s configuration is stored. Possible values are:  
    ///   
    /// * hosted — The Extensions Configuration Service hosts the configuration.
    /// * custom — The Extension Backend Service (EBS) hosts the configuration.
    /// * none — The extension doesn't require configuration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtensionConfigurationLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hosted")]
        Hosted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }
}