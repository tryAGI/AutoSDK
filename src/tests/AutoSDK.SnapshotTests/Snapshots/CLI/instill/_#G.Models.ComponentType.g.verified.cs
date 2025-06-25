//HintName: G.Models.ComponentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ComponentType defines the component type based on its task features.<br/>
    ///  - COMPONENT_TYPE_AI: Connect with an AI model.<br/>
    ///  - COMPONENT_TYPE_DATA: Connect with a remote data source.<br/>
    ///  - COMPONENT_TYPE_OPERATOR: Manipulate data.<br/>
    ///  - COMPONENT_TYPE_APPLICATION: Connect with an external application.<br/>
    ///  - COMPONENT_TYPE_GENERIC: Generic.
    /// </summary>
    public enum ComponentType
    {
        /// <summary>
        /// Connect with an AI model.
        /// </summary>
        AI,
        /// <summary>
        /// Connect with a remote data source.
        /// </summary>
        DATA,
        /// <summary>
        /// Manipulate data.
        /// </summary>
        OPERATOR,
        /// <summary>
        /// Connect with an external application.
        /// </summary>
        APPLICATION,
        /// <summary>
        /// Generic.
        /// </summary>
        GENERIC,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComponentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComponentType value)
        {
            return value switch
            {
                ComponentType.AI => "COMPONENT_TYPE_AI",
                ComponentType.DATA => "COMPONENT_TYPE_DATA",
                ComponentType.OPERATOR => "COMPONENT_TYPE_OPERATOR",
                ComponentType.APPLICATION => "COMPONENT_TYPE_APPLICATION",
                ComponentType.GENERIC => "COMPONENT_TYPE_GENERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComponentType? ToEnum(string value)
        {
            return value switch
            {
                "COMPONENT_TYPE_AI" => ComponentType.AI,
                "COMPONENT_TYPE_DATA" => ComponentType.DATA,
                "COMPONENT_TYPE_OPERATOR" => ComponentType.OPERATOR,
                "COMPONENT_TYPE_APPLICATION" => ComponentType.APPLICATION,
                "COMPONENT_TYPE_GENERIC" => ComponentType.GENERIC,
                _ => null,
            };
        }
    }
}