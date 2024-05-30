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

    public static class ExtensionConfigurationLocationExtensions
    {
        public static string ToValueString(this ExtensionConfigurationLocation value)
        {
            return value switch
            {
                ExtensionConfigurationLocation.Hosted => "hosted",
                ExtensionConfigurationLocation.Custom => "custom",
                ExtensionConfigurationLocation.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionConfigurationLocation ToEnum(string value)
        {
            return value switch
            {
                "hosted" => ExtensionConfigurationLocation.Hosted,
                "custom" => ExtensionConfigurationLocation.Custom,
                "none" => ExtensionConfigurationLocation.None,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionConfigurationLocation ToEnum(int value)
        {
            return value switch
            {
                0 => ExtensionConfigurationLocation.Hosted,
                1 => ExtensionConfigurationLocation.Custom,
                2 => ExtensionConfigurationLocation.None,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}