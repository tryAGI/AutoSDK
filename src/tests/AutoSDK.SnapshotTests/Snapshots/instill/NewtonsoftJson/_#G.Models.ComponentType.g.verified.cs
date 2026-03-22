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
    [global::System.Runtime.Serialization.DataContract]
    public enum ComponentType
    {
        /// <summary>
        /// Connect with an AI model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPONENT_TYPE_AI")]
        Ai,
        /// <summary>
        /// Connect with an external application.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPONENT_TYPE_APPLICATION")]
        Application,
        /// <summary>
        /// Connect with a remote data source.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPONENT_TYPE_DATA")]
        Data,
        /// <summary>
        /// Generic.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPONENT_TYPE_GENERIC")]
        Generic,
        /// <summary>
        /// Manipulate data.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPONENT_TYPE_OPERATOR")]
        Operator,
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
                ComponentType.Ai => "COMPONENT_TYPE_AI",
                ComponentType.Application => "COMPONENT_TYPE_APPLICATION",
                ComponentType.Data => "COMPONENT_TYPE_DATA",
                ComponentType.Generic => "COMPONENT_TYPE_GENERIC",
                ComponentType.Operator => "COMPONENT_TYPE_OPERATOR",
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
                "COMPONENT_TYPE_AI" => ComponentType.Ai,
                "COMPONENT_TYPE_APPLICATION" => ComponentType.Application,
                "COMPONENT_TYPE_DATA" => ComponentType.Data,
                "COMPONENT_TYPE_GENERIC" => ComponentType.Generic,
                "COMPONENT_TYPE_OPERATOR" => ComponentType.Operator,
                _ => null,
            };
        }
    }
}