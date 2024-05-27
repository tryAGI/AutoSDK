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
    public abstract class ExtensionConfigurationLocation
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Hosted = "hosted";
        /// <summary>
        /// 
        /// </summary>
        public const string Custom = "custom";
        /// <summary>
        /// 
        /// </summary>
        public const string None = "none";
    }
}