//HintName: G.Models.ServiceTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:<br/>
    ///   - If set to 'auto', and the Project is Scale tier enabled, the system<br/>
    ///     will utilize scale tier credits until they are exhausted.<br/>
    ///   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
    ///   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarentee.<br/>
    ///   - If set to 'flex', the request will be processed with the Flex Processing service tier. [Learn more](/docs/guides/flex-processing).<br/>
    ///   - When not set, the default behavior is 'auto'.<br/>
    ///   When this parameter is set, the response body will include the `service_tier` utilized.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flex")]
        Flex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTier value)
        {
            return value switch
            {
                ServiceTier.Auto => "auto",
                ServiceTier.Default => "default",
                ServiceTier.Flex => "flex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ServiceTier.Auto,
                "default" => ServiceTier.Default,
                "flex" => ServiceTier.Flex,
                _ => null,
            };
        }
    }
}