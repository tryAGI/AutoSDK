//HintName: G.Models.NodeTransitionMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is a node transition.
    /// </summary>
    public enum NodeTransitionMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        NodeTransition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeTransitionMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeTransitionMessageRole value)
        {
            return value switch
            {
                NodeTransitionMessageRole.NodeTransition => "node_transition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeTransitionMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "node_transition" => NodeTransitionMessageRole.NodeTransition,
                _ => null,
            };
        }
    }
}