//HintName: G.Models.DependencyScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes.
    /// <br/>Example: runtime
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependencyScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="runtime")]
        Runtime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="development")]
        Development,
    }
}