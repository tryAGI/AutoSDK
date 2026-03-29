//HintName: G.Models.SessionsCreateRequestRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The region where the Session should run.<br/>
    /// Default Value: us-west-2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionsCreateRequestRegion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ap-southeast-1")]
        ApSoutheast1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eu-central-1")]
        EuCentral1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us-east-1")]
        UsEast1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us-west-2")]
        UsWest2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsCreateRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsCreateRequestRegion value)
        {
            return value switch
            {
                SessionsCreateRequestRegion.ApSoutheast1 => "ap-southeast-1",
                SessionsCreateRequestRegion.EuCentral1 => "eu-central-1",
                SessionsCreateRequestRegion.UsEast1 => "us-east-1",
                SessionsCreateRequestRegion.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsCreateRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-southeast-1" => SessionsCreateRequestRegion.ApSoutheast1,
                "eu-central-1" => SessionsCreateRequestRegion.EuCentral1,
                "us-east-1" => SessionsCreateRequestRegion.UsEast1,
                "us-west-2" => SessionsCreateRequestRegion.UsWest2,
                _ => null,
            };
        }
    }
}