//HintName: G.Models.Topology.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: triangle
    /// </summary>
    public enum Topology
    {
        /// <summary>
        /// 
        /// </summary>
        Quad,
        /// <summary>
        /// 
        /// </summary>
        Triangle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopologyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Topology value)
        {
            return value switch
            {
                Topology.Quad => "quad",
                Topology.Triangle => "triangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Topology? ToEnum(string value)
        {
            return value switch
            {
                "quad" => Topology.Quad,
                "triangle" => Topology.Triangle,
                _ => null,
            };
        }
    }
}