//HintName: G.Models.SetExtensionConfigurationSegmentRequestSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration segment to update. Possible case-sensitive values are:  
    ///   
    /// * broadcaster
    /// * developer
    /// * global
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SetExtensionConfigurationSegmentRequestSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="broadcaster")]
        Broadcaster,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global")]
        Global,
    }
}