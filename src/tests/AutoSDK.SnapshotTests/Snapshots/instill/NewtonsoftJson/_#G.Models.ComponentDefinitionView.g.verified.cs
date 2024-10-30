//HintName: G.Models.ComponentDefinitionView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// View defines how a component definition is presented.<br/>
    ///  - VIEW_BASIC: Default view, only includes basic information (removes the `spec`<br/>
    /// field).<br/>
    ///  - VIEW_FULL: Full representation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComponentDefinitionView
    {
        /// <summary>
        /// Default view, only includes basic information (removes the `spec`
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        VIEWFULL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComponentDefinitionViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComponentDefinitionView value)
        {
            return value switch
            {
                ComponentDefinitionView.VIEWBASIC => "VIEW_BASIC",
                ComponentDefinitionView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComponentDefinitionView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ComponentDefinitionView.VIEWBASIC,
                "VIEW_FULL" => ComponentDefinitionView.VIEWFULL,
                _ => null,
            };
        }
    }
}