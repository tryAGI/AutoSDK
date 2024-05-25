//HintName: G.Models.PageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the most recent build of the Page.
    /// <br/>Example: built
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="built")]
        Built,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="building")]
        Building,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="errored")]
        Errored,
    }
}