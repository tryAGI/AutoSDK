//HintName: G.Models.Role9e7Enum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `OW` - Owner<br/>
    /// * `AD` - Administrator<br/>
    /// * `MA` - Manager<br/>
    /// * `RE` - Reviewer<br/>
    /// * `AN` - Annotator<br/>
    /// * `DI` - Deactivated<br/>
    /// * `NO` - Not Activated
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Role9e7Enum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AD")]
        Ad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AN")]
        An,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DI")]
        Di,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MA")]
        Ma,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NO")]
        No,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OW")]
        Ow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RE")]
        Re,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Role9e7EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Role9e7Enum value)
        {
            return value switch
            {
                Role9e7Enum.Ad => "AD",
                Role9e7Enum.An => "AN",
                Role9e7Enum.Di => "DI",
                Role9e7Enum.Ma => "MA",
                Role9e7Enum.No => "NO",
                Role9e7Enum.Ow => "OW",
                Role9e7Enum.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Role9e7Enum? ToEnum(string value)
        {
            return value switch
            {
                "AD" => Role9e7Enum.Ad,
                "AN" => Role9e7Enum.An,
                "DI" => Role9e7Enum.Di,
                "MA" => Role9e7Enum.Ma,
                "NO" => Role9e7Enum.No,
                "OW" => Role9e7Enum.Ow,
                "RE" => Role9e7Enum.Re,
                _ => null,
            };
        }
    }
}