//HintName: G.Models.ComponentNodeVariant2ComponentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of component:<br/>
    /// - local: stored in conversation flow's components array<br/>
    /// - shared: stored in stand-alone conversation-flow-component table
    /// </summary>
    public enum ComponentNodeVariant2ComponentType
    {
        /// <summary>
        /// stored in conversation flow's components array
        /// </summary>
        Local,
        /// <summary>
        /// stored in stand-alone conversation-flow-component table
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComponentNodeVariant2ComponentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComponentNodeVariant2ComponentType value)
        {
            return value switch
            {
                ComponentNodeVariant2ComponentType.Local => "local",
                ComponentNodeVariant2ComponentType.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComponentNodeVariant2ComponentType? ToEnum(string value)
        {
            return value switch
            {
                "local" => ComponentNodeVariant2ComponentType.Local,
                "shared" => ComponentNodeVariant2ComponentType.Shared,
                _ => null,
            };
        }
    }
}