//HintName: G.Models.ExtensionConfigurationLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The location of where the extension’s configuration is stored. Possible values are:  <br/>
    ///   <br/>
    /// * hosted — The Extensions Configuration Service hosts the configuration.<br/>
    /// * custom — The Extension Backend Service (EBS) hosts the configuration.<br/>
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtensionConfigurationLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtensionConfigurationLocation? ToEnum(string value)
        {
            return value switch
            {
                "hosted" => ExtensionConfigurationLocation.Hosted,
                "custom" => ExtensionConfigurationLocation.Custom,
                "none" => ExtensionConfigurationLocation.None,
                _ => null,
            };
        }
    }
}