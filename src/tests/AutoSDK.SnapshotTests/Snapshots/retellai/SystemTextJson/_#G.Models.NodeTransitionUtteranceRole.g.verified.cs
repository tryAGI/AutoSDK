//HintName: G.Models.NodeTransitionUtteranceRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is result of a node transition
    /// </summary>
    public enum NodeTransitionUtteranceRole
    {
        /// <summary>
        /// 
        /// </summary>
        NodeTransition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeTransitionUtteranceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeTransitionUtteranceRole value)
        {
            return value switch
            {
                NodeTransitionUtteranceRole.NodeTransition => "node_transition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeTransitionUtteranceRole? ToEnum(string value)
        {
            return value switch
            {
                "node_transition" => NodeTransitionUtteranceRole.NodeTransition,
                _ => null,
            };
        }
    }
}