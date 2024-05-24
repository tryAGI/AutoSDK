//HintName: G.Models.RepositoryAdvisoryUpdateState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the advisory.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryUpdateState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="published")]
        Published,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="draft")]
        Draft,
    }
}