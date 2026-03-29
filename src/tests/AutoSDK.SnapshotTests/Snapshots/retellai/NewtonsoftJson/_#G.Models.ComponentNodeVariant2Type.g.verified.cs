//HintName: G.Models.ComponentNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComponentNodeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="component")]
        Component,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComponentNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComponentNodeVariant2Type value)
        {
            return value switch
            {
                ComponentNodeVariant2Type.Component => "component",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComponentNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "component" => ComponentNodeVariant2Type.Component,
                _ => null,
            };
        }
    }
}