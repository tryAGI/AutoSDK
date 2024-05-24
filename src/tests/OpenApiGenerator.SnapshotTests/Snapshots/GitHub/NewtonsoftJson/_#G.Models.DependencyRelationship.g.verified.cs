//HintName: G.Models.DependencyRelationship.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.
    /// <br/>Example: direct
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependencyRelationship
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="direct")]
        Direct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="indirect")]
        Indirect,
    }
}