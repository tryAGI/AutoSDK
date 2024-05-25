//HintName: G.Models.PageBuildType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The process in which the Page will be built.
    /// <br/>Example: legacy
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PageBuildType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy")]
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow")]
        Workflow,
    }
}