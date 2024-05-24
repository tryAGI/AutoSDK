//HintName: G.Models.DependencyRelationship.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.
    /// <br/>Example: direct
    /// </summary>
    public abstract class DependencyRelationship
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Direct = "direct";
        /// <summary>
        /// 
        /// </summary>
        public const string Indirect = "indirect";
    }
}